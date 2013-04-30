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
using WinterLeaf.Containers;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        [Torque_Decorations.TorqueCallBack("", "MessageHud", "open", "(this)", 1, 5000, false)]
        public void MessageHudOpen(coGuiControl thisobj)
            {
            const int offset = 6;

            if (thisobj.isVisible())
                return;


            string text = thisobj[thisobj + ".isTeamMsg"].AsBool() ? "TEAM:" : "GLOBAL:";

            coGuiTextCtrl MessageHud_Text = "MessageHud_Text";

            MessageHud_Text.setValue(text);

            coGuiBitmapBorderCtrl outerChatHud = "outerChatHud";
            coGuiBitmapBorderCtrl MessageHud_Frame = "MessageHud_Frame";

            //string windowPos = "0 " + outerChatHud["position"].Split(' ')[1] + (outerChatHud["extent"].Split(' ')[1].AsInt() + 1);
            Point2I windowPos = new Point2I(0, (outerChatHud.position.y + outerChatHud.extent.y + 1));

            //            string windowExt = outerChatHud["extent"].Split(' ')[0] + " " + MessageHud_Frame["extent"].Split(' ')[1];
            Point2I windowExt = new Point2I(outerChatHud.extent.x, MessageHud_Frame.extent.y);


            //int textExtent = MessageHud_Text["extent"].Split(' ')[0].AsInt() + 14;
            int textExtent = MessageHud_Text.extent.x + 14;
            //int ctrlExtent = MessageHud_Frame["extent"].Split(' ')[0].AsInt();
            int ctrlExtent = MessageHud_Frame.extent.x;

            ((coGuiCanvas)"Canvas").pushDialog(thisobj);

            MessageHud_Frame.position = windowPos;
            MessageHud_Frame.extent = windowExt;

            coGuiTextEditCtrl MessageHud_Edit = "MessageHud_Edit";

            MessageHud_Edit.position.x = textExtent + offset;


            MessageHud_Edit.extent.x = (ctrlExtent - textExtent - (2*offset));

            thisobj.setVisible(true);

            console.Call("deactivateKeyboard");

            MessageHud_Edit.makeFirstResponder(true.AsString());
            }

        [Torque_Decorations.TorqueCallBack("", "MessageHud", "close", "(this)", 1, 5000, false)]
        public void MessageHudClose(coGuiControl thisobj)
            {
            if (!thisobj.isVisible())
                return;

            (( coGuiCanvas)"Canvas").popDialog(thisobj);
            thisobj.setVisible(false);


            if (bGlobal["$enableDirectInput"])
                console.Call("activateKeyboard");

            (( coGuiTextEditCtrl)"MessageHud_Edit").setValue("");
            }

        [Torque_Decorations.TorqueCallBack("", "MessageHud", "toggleState", "(this)", 1, 5000, false)]
        public void MessageHudToggleState(coGuiControl thisobj)
            {
            if (thisobj.isVisible())
                MessageHudClose(thisobj);
            else
                MessageHudOpen(thisobj);
            }

        [Torque_Decorations.TorqueCallBack("", "MessageHud_Edit", "onEscape", "(this)", 1, 5000, false)]
        public void MessageHudEditOnEscape(coGuiControl thisobj)
            {
            MessageHudClose("MessageHud");
            }

        [Torque_Decorations.TorqueCallBack("", "MessageHud_Edit", "eval", "(this)", 1, 5000, false)]
        public void MessageHudEditEval(coGuiControl thisobj)
            {
            string text = Util.collapseEscape(thisobj.getValue().Trim());
            coGuiControl MessageHud = "MessageHud";

            if (text != "")
                {
                console.commandToServer(MessageHud["isTeamMsg"].AsBool() ? "teamMessageSent" : "messageSent", new[] {text});
                }
            //MessageHud.call("close");
            MessageHudClose(MessageHud);
            }

        //----------------------------------------------------------------------------
        // MessageHud key handlers
        [Torque_Decorations.TorqueCallBack("", "", "toggleMessageHud", "(make)", 1, 5000, false)]
        public void ToggleMessageHud(bool make)
            {
            if (make)
                {
                coGuiControl MessageHud = "MessageHud";
                MessageHud["isTeamMsg"] = false.AsString();
                MessageHudToggleState(MessageHud);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "teamMessageHud", "(make)", 1, 5000, false)]
        public void TeamMessageHud(bool make)
            {
            if (make)
                {
                coGuiControl MessageHud = "MessageHud";
                MessageHud["isTeamMsg"] = true.AsString();
                MessageHudToggleState(MessageHud);
                }
            }
        }
    }