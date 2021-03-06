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

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        //------------------------------------------------------------------------------
        // CloudLayer
        //------------------------------------------------------------------------------


        //-----------------------------------------------------------------------------
        // Functions that process commands sent from the server.


        // This function is for chat messages only; it is invoked on the client when
        // the server does a commandToClient with the tag ChatMessage.  (Cf. the
        // functions chatMessage* in core/scripts/server/message.cs.)

        // This just invokes onChatMessage, which the mod code must define.
        [Torque_Decorations.TorqueCallBack("", "", "clientCmdChatMessage", "%sender, %voice, %pitch, %msgString, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10", 14, 50000, false)]
        public void clientCmdChatMessage(string sender, string voice, string pitch, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            OnChatMessage(Util.detag(msgString), voice, pitch);
            }


        // Game event descriptions, which may or may not include text messages, can be
        // sent using the message* functions in core/scripts/server/message.cs.  Those
        // functions do commandToClient with the tag ServerMessage, which invokes the
        // function below.

        // For ServerMessage messages, the client can install callbacks that will be
        // run, according to the "type" of the message.
        [Torque_Decorations.TorqueCallBack("", "", "clientCmdServerMessage", "%msgType, %msgString, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10", 12, 50000, false)]
        public void clientCmdServerMessage(string msgType, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            string tag = msgType.Split(' ')[0].Trim();
            string funct;

            int i = 0;
            while ((funct = console.GetVarString(@"$MSGCB["""", " + i.AsString() + "]")) != "")
                {
                console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});

                i++;
                }

            // Next look for a callback for this particular type of ServerMessage.
            if (tag == "")
                return;
            i = 0;
            while ((funct = console.GetVarString(@"$MSGCB[""" + tag + @""", " + i.AsString() + "]")) != "")
                {
                console.Call(funct, new[] {msgType, msgString, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10});
                i++;
                }
            }


        // Called by the client to install a callback for a particular type of
        // ServerMessage.
        [Torque_Decorations.TorqueCallBack("", "", "addMessageCallback", "%msgType, %func", 2, 32000, false)]
        public void addMessageCallback(string msgType, string func)
            {
            //For some reason, when the msgType is "" it makes it " "... somewheres it must
            //be appending an empty space to the string, just no clue whear.
            msgType = msgType.Trim();
            string afunc = "";
            int i = 0;
            while ((afunc = console.GetVarString(@"$MSGCB[""" + msgType + @""", " + i.AsString() + "]")) != "")
                {
                if (afunc == func)
                    return;
                i++;
                }
            console.SetVar(@"$MSGCB[""" + msgType + @""", " + i.AsString() + "]", func);
            }

        // The following is the callback that will be executed for every ServerMessage,
        // because we're going to install it without a specified type.  Any type-
        // specific callbacks will be executed afterward.

        // This just invokes onServerMessage, which can be overridden by the game

        //[Torque_Decorations.TorqueCallBack("", "", "onServerMessage", "%a, %b, %c, %d, %e, %f, %g, %h, %i", 9, 32000, false)]
        //public void OnServerMessage(string a, string b , string c , string d , string e , string f , string g , string h, string i )
        //    {
        //    console.print("onServerMessage: ");
        //    if (a != "") console.print("  +- a: " + a);
        //    if (b != "") console.print("  +- b: " + b);
        //    if (c != "") console.print("  +- c: " + c);
        //    if (d != "") console.print("  +- d: " + d);
        //    if (e != "") console.print("  +- e: " + e);
        //    if (f != "") console.print("  +- f: " + f);
        //    if (g != "") console.print("  +- g: " + g);
        //    if (h != "") console.print("  +- h: " + h);
        //    if (i != "") console.print("  +- i: " + i);
        //    }
        [Torque_Decorations.TorqueCallBack("", "", "defaultMessageCallback", "%msgType, %msgString, %a1, %a2, %a3, %a4, %a5, %a6, %a7, %a8, %a9, %a10", 12, 50000, false)]
        public void defaultMessageCallback(string msgType, string msgString, string a1, string a2, string a3, string a4, string a5, string a6, string a7, string a8, string a9, string a10)
            {
            OnServerMessage(Util.detag(msgString));
            }

        [Torque_Decorations.TorqueCallBack("", "", "RegisterDefaultMessageHandler", "", 0, 50000, true)]
        public void RegisterDefaultMessageHandler()
            {
            addMessageCallback("", "defaultMessageCallback");
            }
        }
    }