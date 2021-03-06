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
        [Torque_Decorations.TorqueCallBack("", "GameConnection", "loadMission", "(%this)", 1, 14000, false)]
        public void GameConnectionLoadMission(coGameConnection client)
            {
            // Send over the information that will display the server info
            // when we learn it got there, we'll send the data blocks

            client["currentPhase"] = "0";

            if (client.isAIControlled())
                GameConnectionOnClientEnterGame(client);
            else
                {
                if (client.isObject())
                    console.commandToClient(client, "MissionStartPhase1", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"], sGlobal["MissionGroup.musicTrack"]});
                console.print("*** Sending mission load to client: " + sGlobal["$Server::MissionFile"]);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdMissionStartPhase1Ack", "(%client, %seq)", 2, 14000, false)]
        public void ServerCmdMissionStartPhase1Ack(coGameConnection client, string seq)
            {
            // Make sure to ignore calls from a previous mission load
            if (seq != sGlobal["$missionSequence"] || !missionRunning)
                return;
            if (client["currentPhase"].AsDouble() != 0.0)
                return;

            client["currentPhase"] = "1";
            // Start with the CRC

            client.setMissionCRC(iGlobal["$missionCRC"]);

            // Send over the datablocks...
            // OnDataBlocksDone will get called when have confirmation
            // that they've all been received.
            console.print("Transmitting Datablocks");
            client.transmitDataBlocks(iGlobal["$missionSequence"]);
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onDataBlocksDone", "( %this, %missionSequence)", 2, 14000, false)]
        public void GameConnectiononDataBlocksDone(coGameConnection thisobj, string missionSequence)
            {
            // Make sure to ignore calls from a previous mission load
            if (missionSequence != sGlobal["$missionSequence"])
                return;
            if (thisobj["currentPhase"].AsInt() != 1)
                return;
            thisobj["currentPhase"] = "1.5";
            // On to the next phase
            if (thisobj.isObject())
                console.commandToClient(thisobj, "MissionStartPhase2", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"]});
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdMissionStartPhase2Ack", "(%client, %seq, %playerDB)", 3, 14000, false)]
        public void ServerCmdMissionStartPhase2Ack(coGameConnection client, string seq, coPlayerData playerDB)
            {
            // Make sure to ignore calls from a previous mission load
            if (seq != sGlobal["$missionSequence"] || !missionRunning)
                return;
            if (client["currentPhase"].AsDouble() != 1.5)
                return;

            client["currentPhase"] = "2";
            // Set the player datablock choice

            client["playerDB"] = playerDB;

            // Update mod paths, this needs to get there before the objects.
            client.transmitPaths();

            // Start ghosting objects to the client
            client.activateGhosting();
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "clientWantsGhostAlwaysRetry", "(%client)", 1, 14000, false)]
        public void ClientWantsGhostAlwaysRetry(coGameConnection client)
            {
            if (missionRunning)
                client.activateGhosting();
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onGhostAlwaysFailed", "(%client)", 1, 14000, false)]
        public void OnGhostAlwaysFailed(coGameConnection client)
            {
            }

        [Torque_Decorations.TorqueCallBack("", "GameConnection", "onGhostAlwaysObjectsReceived", "(%client)", 1, 14000, false)]
        public void OnGhostAlwaysObjectsReceived(coGameConnection client)
            {
            // Ready for next phase.
            console.commandToClient(client, "MissionStartPhase3", new[] {sGlobal["$missionSequence"], sGlobal["$Server::MissionFile"]});
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdMissionStartPhase3Ack", "(%client, %seq)", 2, 14000, false)]
        public void ServerCmdMissionStartPhase3Ack(coGameConnection client, string seq)
            {
            if (seq != sGlobal["$missionSequence"] || !missionRunning)
                return;
            if (client["currentPhase"].AsDouble() != 2.0)
                return;

            client["currentPhase"] = "3";
            // Server is ready to drop into the game

            GameConnectionstartMission(client);
            GameConnectionOnClientEnterGame(client);
            }
        }
    }