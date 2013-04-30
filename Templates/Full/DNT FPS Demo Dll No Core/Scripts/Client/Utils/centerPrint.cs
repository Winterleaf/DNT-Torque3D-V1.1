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
        [Torque_Decorations.TorqueCallBack("", "", "centerprint_Init", "", 0, 38000, true)]
        public void centerprint_Init()
            {
            iGlobal["$centerPrintActive"] = 0;
            iGlobal["$bottomPrintActive"] = 0;
            iGlobal["$CenterPrintSizes[1]"] = 20;
            iGlobal["$CenterPrintSizes[2]"] = 36;
            iGlobal["$CenterPrintSizes[3]"] = 56;
            }

        [Torque_Decorations.TorqueCallBack("", "", "clientCmdCenterPrint", "%message, %time, %size", 3, 38000, false)]
        public void clientCmdCenterPrint(string message, string time, string size)
            {
            coGuiBitmapCtrl centerPrintDlg = "centerPrintDlg";

            if (bGlobal["$centerPrintActive"])
                {
                if (centerPrintDlg.call("removePrint") != "")
                    Util._cancel(centerPrintDlg["removePrint"]);
                }
            else
                {
                centerPrintDlg["isVisible"] = "1";
                iGlobal["$centerPrintActive"] = 1;
                }

            ((coGuiMLTextCtrl)"CenterPrintText").setText("<just:center>" + message);
            centerPrintDlg.extent.y = iGlobal["$CenterPrintSizes[" + size + "]"];

            //centerPrintDlg["extent"] = Util.firstWord(centerPrintDlg["extent"]) + " " + sGlobal["$CenterPrintSizes[" + size + "]"];

            if (time.AsInt() > 0)
                centerPrintDlg["removePrint"] = Util._schedule((time.AsInt()*1000).AsString(), "0", "clientCmdClearCenterPrint").AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "", "clientCmdBottomPrint", "%message, %time, %size", 3, 38000, false)]
        public void clientCmdBottomPrint(string message, string time, string size)
            {
            coGuiBitmapCtrl bottomPrintDlg = "bottomPrintDlg";

            if (bGlobal["$bottomPrintActive"])
                {
                if (bottomPrintDlg.call("removePrint") != "")
                    Util._cancel(bottomPrintDlg["removePrint"]);
                }
            else
                {
                bottomPrintDlg["isVisible"] = "1";
                iGlobal["$bottomPrintActive"] = 1;
                }

            ((coGuiMLTextCtrl)"bottomPrintText").setText("<just:center>" + message);

            bottomPrintDlg.extent.y = iGlobal["$CenterPrintSizes[" + size + "]"];
            //bottomPrintDlg["Extent"] = Util.firstWord(bottomPrintDlg["extent"]) + " " + sGlobal["$CenterPrintSizes[" + size + "]"];


            if (time.AsInt() > 0)
                bottomPrintDlg["removePrint"] = Util._schedule((time.AsInt()*1000).AsString(), "0", "clientCmdClearbottomPrint").AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "BottomPrintText", "onResize", "%this, %width, %height", 3, 38000, false)]
        public void BottomPrintTextonResize(coGuiMLTextCtrl thisobj, string width, string height)
            {
            thisobj.position =new Point2I(0,0);
            }

        [Torque_Decorations.TorqueCallBack("", "CenterPrintText", "onResize", "%this, %width, %height", 3, 38000, false)]
        public void CenterPrintTextOnResize(coGuiMLTextCtrl thisobj, string width, string height)
            {
            thisobj.position= new Point2I(0,0);
            }

        [Torque_Decorations.TorqueCallBack("", "", "clientCmdClearCenterPrint", "", 0, 38000, false)]
        public void clientCmdClearCenterPrint()
            {
            iGlobal["$centerPrintActive"] = 0;
            coGuiMLTextCtrl CenterPrintDlg = "CenterPrintDlg";
            CenterPrintDlg.visible = false;
            CenterPrintDlg["removePrint"] = "";

            //new coGuiMLTextCtrl("CenterPrintDlg")["visible"] = "0";
            //new coGuiMLTextCtrl("CenterPrintDlg")["removePrint"] = "";
            }

        [Torque_Decorations.TorqueCallBack("", "", "clientCmdClearBottomPrint", "", 0, 38000, false)]
        public void clientCmdClearBottomPrint()
            {
            iGlobal["$bottomPrintActive"] = 0;
            coGuiMLTextCtrl BottomPrintDlg = "BottomPrintDlg";
            BottomPrintDlg.visible = false;
            BottomPrintDlg["removePrint"] = "";
            //new coGuiMLTextCtrl("BottomPrintDlg")["visible"] = "0";
            //new coGuiMLTextCtrl("BottomPrintDlg")["removePrint"] = "";
            }
        }
    }