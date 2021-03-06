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

using System;
using WinterLeaf.Classes;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        [Torque_Decorations.TorqueCallBack("", "", "init_missioncs", "()", 0, 51000, true)]
        public void init_missioncs()
            {
            // Whether the local client is currently running a mission.
            bGlobal["$Client::missionRunning"] = false;
            // Sequence number for currently running mission.
            iGlobal["$Client::missionSeq"] = -1;
            }

        // Called when mission is started.
        [Torque_Decorations.TorqueCallBack("", "", "clientStartMission", "()", 0, 51000, false)]
        public void clientStartMission()
            {
            // The client recieves a mission start right before
            // being dropped into the game.
            Util._physicsStartSimulation("client");
            // Start game audio effects channels.
            (( coSFXSource)"AudioChannelEffects").play(-1);
            // Create client mission cleanup group.
            new Torque_Class_Helper("SimGroup", "ClientMissionCleanup").Create();
            bGlobal["$Client::missionRunning"] = true;
            }

        // Called when mission is ended (either through disconnect or
        // mission end client command).
        [Torque_Decorations.TorqueCallBack("", "", "clientEndMission", "()", 0, 51000, false)]
        public void clientEndMission()
            {
            // Stop physics simulation on client.
            Util._physicsStopSimulation("client");
            // Stop game audio effects channels.

            (( coSFXSource)"AudioChannelEffects").stop(-1);

            console.Call("decalManagerClear");
            // Delete client mission cleanup group. 

                (( coSimGroup)"ClientMissionCleanup").delete();
            
            Util._clearClientPaths();

            bGlobal["$Client::missionRunning"] = false;
            }

        //----------------------------------------------------------------------------
        // Mission start / end events sent from the server
        //----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "", "clientCmdMissionStart", "(%seq)", 1, 51000, false)]
        public void clientCmdMissionStart(string seq)
            {
            clientStartMission();

            sGlobal["$Client::missionSeq"] = seq;
            }

        [Torque_Decorations.TorqueCallBack("", "", "clientCmdMissionEnd", "(%seq)", 1, 51000, false)]
        public void clientCmdMissionEnd(string seq)
            {
            if (!bGlobal["$Client::missionRunning"] || sGlobal["$Client::missionSeq"] != seq)
                return;
            clientEndMission();
            iGlobal["$Client::missionSeq"] = -1;
            }

        /// Expands the name of a mission into the full 
        /// mission path and extension.
        [Torque_Decorations.TorqueCallBack("", "", "expandMissionFileName", "(%missionFile)", 1, 51000, false)]
        public string expandMissionFileName(string missionFile)
            {
            // Expand any escapes in it.

            missionFile = Util._expandFilename(missionFile);
            string newMission = "";
            if (!Util.isFile(missionFile))
                {
                if (!missionFile.Trim().EndsWith(".mis"))
                    newMission = missionFile.Trim() + ".mis";

                if (!Util.isFile(newMission))
                    {
                    newMission = Util._expandFilename("levels/" + newMission);

                    if (!Util.isFile(newMission))
                        {
                        console.warn("The mission file '" + missionFile + "' was not found.");
                        return "";
                        }
                    }
                missionFile = newMission;
                }
            return missionFile;
            }

        /// Load a single player level on the local server.
        [Torque_Decorations.TorqueCallBack("", "", "loadLevel", "(%missionNameOrFile)", 1, 51000, false)]
        public string loadLevel(string missionNameOrFile)
            {
            // Expand the mission name... this allows you to enter
            // just the name and not the full path and extension.
            string missionFile = expandMissionFileName(missionNameOrFile);
            if (missionFile == "")
                return "false";
            // Show the loading screen immediately.

            if (((coGuiChunkedBitmapCtrl)"LoadingGui").isObject())
                {
                //if it can't find the loading gui it will throw an exception and leave the try block.
                
                ((coGuiCanvas)"Canvas").setContent("LoadingGui");
                ((coGuiProgressBitmapCtrl)"LoadingProgress").setValue("1");
                ((coGuiTextCtrl)"LoadingProgressTxt").setValue("LOADING MISSION FILE");
                ((coGuiCanvas)"Canvas").repaint(0);
                }
            

            // Prepare and launch the server.

            return console.Call("createAndConnectToLocalServer", new[] {"SinglePlayer", missionFile});
            }
        }
    }