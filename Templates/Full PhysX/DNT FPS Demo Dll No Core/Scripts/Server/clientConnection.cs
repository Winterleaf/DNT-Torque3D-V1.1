﻿// Copyright (C) 2012 Winterleaf Entertainment L,L,C.
// 
// THE SOFTW ARE IS PROVIDED ON AN “ AS IS” BASIS, WITHOUT W ARRANTY OF ANY KIND,
// INCLUDING WITHOUT LIMIT ATION THE W ARRANTIES OF MERCHANT ABILITY, FITNESS
// FOR A PARTICULAR PURPOSE OR NON-INFRINGEMENT . THE ENTIRE RISK AS TO THE
// QUALITY AND PERFORMANCE OF THE SOFTW ARE IS THE RESPONSIBILITY OF LICENSEE.
// SHOULD THE SOFTW ARE PROVE DEFECTIVE IN ANY RESPECT , LICENSEE AND NOT LICEN -
// SOR OR ITS SUPPLIERS OR RESELLERS ASSUMES THE ENTIRE COST OF AN Y SERVICE AND
// REPAIR. THIS DISCLAIMER OF W ARRANTY CONSTITUTES AN ESSENTIAL PART OF THIS
// AGREEMENT. NO USE OF THE SOFTW ARE IS AUTHORIZED HEREUNDER EXCEPT UNDER
// THIS DISCLAIMER.
// 
// The use of the WinterLeaf Entertainment LLC DotNetT orque (“DNT ”) and DotNetT orque
// Customizer (“DNTC”)is governed by this license agreement (“ Agreement”).
// 
// R E S T R I C T I O N S
// 
// (a) Licensee may not: (i) create any derivative works of DNTC, including but not
// limited to translations, localizations, technology add-ons, or game making software
// other than Games; (ii) reverse engineer , or otherwise attempt to derive the algorithms
// for DNT or DNTC (iii) redistribute, encumber , sell, rent, lease, sublicense, or otherwise
// transfer rights to  DNTC; or (iv) remove or alter any tra demark, logo, copyright
// or other proprietary notices, legends, symbols or labels in DNT or DNTC; or (iiv) use
// the Software to develop or distribute any software that compete s with the Software
// without WinterLeaf Entertainment’s prior written consent; or (i iiv) use the Software for
// any illegal purpose.
// (b) Licensee may not distribute the DNTC in any manner.
// 
// LI C E N S E G R A N T .
// This license allows companies of any size, government entities or individuals to cre -
// ate, sell, rent, lease, or otherwise profit commercially from, games using executables
// created from the source code of DNT
// 
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// THE SOURCE CODE GENERATED BY DNTC CAN BE  DISTRIBUTED PUBLICLY PROVIDED THAT THE 
// DISTRIBUTOR PROVIDES  THE GENERATE SOURCE CODE FREE OF CHARGE.
// 
// THIS SOURCE CODE (DNT) CAN BE DISTRIBUTED PUBLICLY PROVIDED THAT THE DISTRIBUTOR 
// PROVIDES  THE SOURCE CODE (DNT) FREE OF CHARGE.
// **********************************************************************************
// **********************************************************************************
// **********************************************************************************
// 
// Please visit http://www.winterleafentertainment.com for more information about the project and latest updates.
// 
// 
// 

#region

using WinterLeaf.Classes;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    public partial class Main : TorqueScriptTemplate
        {
        public string Server__LoadFailMsg = string.Empty;
        public int Server__PlayerCount;

        public int pref__Server__MaxPlayers = 64;

        [Torque_Decorations.TorqueCallBack("", "", "sendLoadInfoToClient", "(%client)", 1, 15000, false)]
        private void SendLoadInfoToClient(coGameConnection client)
            {
            coLevelInfo theLevelInfo = "theLevelInfo";

            MessageClient(client, "MsgLoadInfo", "", theLevelInfo["levelName"]);

            for (int i = 0; theLevelInfo["desc[" + i + "]"] != ""; i++)

                MessageClient(client, "MsgLoadDescripition", "", theLevelInfo["desc[" + i + "]"]);

            MessageClient(client, "MsgLoadInfoDone", "");
            }


        //-----------------------------------------------------------------------------
        // This script function is called before a client connection
        // is accepted.  Returning "" will accept the connection,
        // anything else will be sent back as an error to the client.
        // All the connect args are passed also to onConnectRequest
        //
        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onConnectRequest", "( %client, %netAddress, %name )", 3, 15000, false)]
        public string GameConnectionOnConnectRequest(coGameConnection client, string netAddress, string name)
            {
            console.print(string.Format("Connect request from:{0}", netAddress));
            return Server__PlayerCount >= pref__Server__MaxPlayers ? "CR_SERVERFULL" : "";
            }

        //-----------------------------------------------------------------------------
        // This script function is the first called on a client accept
        //
        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onConnect", "( %client, %name )", 2, 15000, false)]
        public void GameConnectionOnConnect(coGameConnection client, string name)
            {
            // Send down the connection error info, the client is
            // responsible for displaying this message if a connection
            // error occures.
            MessageClient(client, "MsgConnectionError", "", sGlobal["$Pref::Server::ConnectionError"]);
            // Send mission information to the client
            SendLoadInfoToClient(client);
            // Simulated client lag for testing...
            // %client.setSimulatedNetParams(0.1, 30);

            // Get the client's unique id:
            // %authInfo = %client.getAuthInfo();
            // %client.guid = getField( %authInfo, 3 );

            client["guid"] = "0";


            AddToServerGuidList(client["guid"]);
            // Set admin status
            if (client.getAddress() == "local")
                {
                client["isAdmin"] = true.AsString();
                client["isSuperAdmin"] = true.AsString();
                }
            else
                {
                client["isAdmin"] = false.AsString();
                client["isSuperAdmin"] = false.AsString();
                }
            // Save client preferences on the connection object for later use.

            client["gender"] = "Male";
            client["armor"] = "Light";
            client["race"] = "human";
            client["skin"] = console.addTaggedString("base");

            GameConnectionSetPlayerName(client, name);
            client["team"] = "";
            client["score"] = "0";

            console.print("CADD: " + client + " " + client.getAddress());


            // If the mission is running, go ahead download it to the client
            if (missionRunning)
                GameConnectionLoadMission(client);
            else if (Server__LoadFailMsg != "")
                MessageClient(client, "MsgLoadFailed", Server__LoadFailMsg);

            Server__PlayerCount++;
            }

        //-----------------------------------------------------------------------------
        // A player's name could be obtained from the auth server, but for
        // now we use the one passed from the client.
        // %realName = getField( %authInfo, 0 );
        //

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "setPlayerName", "( %client, %name )", 2, 15000, false)]
        public void GameConnectionSetPlayerName(coGameConnection client, string name)
            {
            client["sendGuid"] = "0";


            // Minimum length requirements
            name = Util._strToPlayerName(name).Trim();
            if (name.Length < 3)
                name = "Poser";

            // Make sure the alias is unique, we'll hit something eventually
            if (!IsNameUnique(name))
                {
                bool isUnique = false;
                string nametry = "NotSet";
                for (int suffix = 1; !isUnique; suffix++)
                    {
                    nametry = name + "." + suffix;
                    isUnique = IsNameUnique(nametry);
                    }
                name = nametry;
                }
            client["nameBase"] = name;
            client["playerName"] = console.addTaggedString(console.ColorEncode(string.Format(@"\cp\c8{0}\co", name)));
            }

        [Torque_Decorations.TorqueCallBack("", "", "isNameUnique", "(  %name )", 1, 15000, false)]
        public bool IsNameUnique(string name)
            {
            foreach (coGameConnection client in ClientGroup)
                {
                string rawName = "";

                if (client["playerName"].Trim().Length > 0)
                    rawName = Util.stripChars(Util.detag(console.getTaggedString(client["playerName"])), console.ColorEncode(@"\cp\co\c6\c8\c9"));
                if (name == rawName)
                    return false;
                }
            return true;
            }

        //-----------------------------------------------------------------------------
        // This function is called when a client drops for any reason
        //

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onDrop", "( %client, %reason )", 2, 15000, false)]
        public void GameConnectiononDrop(coGameConnection client, string reason)
            {
            GameConnectionOnClientLeaveGame(client);

            RemoveFromServerGuidList(client["guid"]);

            MessageAllExcept(client, "-1", "MsgClientDrop", console.ColorEncode(@"\c1%1 has left the game."), client["playerName"], client);


            console.removeTaggedString(client["playerName"]);

            console.print(string.Format("CDROP: {0} {1}", client, client.getAddress()));


            Server__PlayerCount--;
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "startMission", "( %this )", 1, 15000, false)]
        public void GameConnectionstartMission(coGameConnection client)
            {
            // Inform the client the mission starting
            console.commandToClient(client, "MissionStart", new[] {sGlobal["$missionSequence"]});
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "endMission", "( %this )", 1, 15000, false)]
        public void GameConnectionendMission(coGameConnection client)
            {
            // Inform the client the mission is done.  Note that if this is
            // called as part of the server destruction routine, the client will
            // actually never see this comment since the client connection will
            // be destroyed before another round of command processing occurs.
            // In this case, the client will only see the disconnect from the server
            // and should manually trigger a mission cleanup.
            console.commandToClient(client, "MissionEnd", new[] {sGlobal["$missionSequence"]});
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "syncClock", "( %%client, %time )", 2, 15000, false)]
        public void GameConnectionsyncClock(coGameConnection client, string time)
            {
            console.commandToClient(client, "syncClock", new[] {time});
            }

        //--------------------------------------------------------------------------
        // Update all the clients with the new score

        //[Torque_Decorations.TorqueCallBack("", "GameConnection", "incScore", "(%this,%delta)", 2, 15000, false)]
        //public void GameConnectionincScore(string client, string delta)
        //    {
        //    console.SetVar(client + ".score", console.GetVarInt(client + ".score") + delta);

        //    MessageAll("MsgClientScoreChanged", "", console.GetVarString(client + ".score"), client);
        //    }
        }
    }