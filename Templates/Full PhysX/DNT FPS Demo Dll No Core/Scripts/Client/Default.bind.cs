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
using WinterLeaf.Enums;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        //-----------------------------------------------------------------------------
        // Torque
        // Copyright GarageGames, LLC 2011
        //-----------------------------------------------------------------------------

        // Game specific audio descriptions. Always declare SFXDescription's (the type of sound)
        // before SFXProfile's (the sound itself) when creating new ones


        private int movementSpeed = 1;

        [Torque_Decorations.TorqueCallBack("", "", "init_Default_Bind", "()", 0, 11000, true)]
        public void initDefaultBind()
            {
            coActionMap moveMap = "moveMap";
            if (moveMap.isObject())
                moveMap.delete();

            new Torque_Class_Helper("ActionMap", "moveMap").Create();

            if (console.GetVarString("$Player::CurrentFOV") == "")
                console.SetVar("$Player::CurrentFOV", console.GetVarFloat("$pref::Player::DefaultFOV") / (float)2.0);

            console.SetVar("$MFDebugRenderMode", 0);

            coActionMap vehicleMap = "vehicleMap";
            if (vehicleMap.isObject())
                vehicleMap.delete();

            new Torque_Class_Helper("ActionMap", "vehicleMap").Create();
            }

        [Torque_Decorations.TorqueCallBack("", "", "escapeFromGame", "()", 0, 11001, false)]
        public void escapeFromGame()
            {
            console.Call("MessageBoxYesNo", console.GetVarString("$Server::ServerType") == "SinglePlayer" ? new[] { "Exit", "Exit from this Mission?", "disconnect();", "" } : new[] { "Disconnect", "Disconnect from the server?", "disconnect();", "" });
            }

        [Torque_Decorations.TorqueCallBack("", "", "showPlayerList", "(val)", 1, 11001, false)]
        public void showPlayerList(bool val)
            {
            if (val)
                PlayerListGuiToggle("PlayerListGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "showControlsHelp", "(val)", 1, 11001, false)]
        public void showControlsHelp(bool val)
            {
            if (val)
                console.Call("ControlsHelpDlg", "toggle");
            }

        [Torque_Decorations.TorqueCallBack("", "", "hideHUDs", "(val)", 1, 11001, false)]
        public void hideHUDs(bool val)
            {
            if (val)
                console.Call("HudlessPlayGui", "toggle");
            }

        [Torque_Decorations.TorqueCallBack("", "", "doScreenShotHudless", "(val)", 1, 11001, false)]
        public void doScreenShotHudless(bool val)
            {
            if (val)
                {
                ((coGuiCanvas)"canvas").setContent("HudlessPlayGui");
                Util._schedule("10", "0", "doScreenShot", val.AsString());
                }
            else
                {
                ((coGuiCanvas)"canvas").setContent("PlayGui");
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "setSpeed", "(Speed)", 1, 11001, false)]
        public void setSpeed(int speed)
            {
            if (speed.AsBool())
                movementSpeed = speed;
            }

        [Torque_Decorations.TorqueCallBack("", "", "moveleft", "(val)", 1, 11001, false)]
        public void moveleft(int val)
            {
            iGlobal["$mvLeftAction"] = val * movementSpeed;
            //console.SetVar("$mvLeftAction", val.AsInt()*movementSpeed);
            }

        [Torque_Decorations.TorqueCallBack("", "", "moveright", "(val)", 1, 11001, false)]
        public void moveright(int val)
            {
            //console.SetVar("$mvRightAction", val.AsInt()*movementSpeed);
            iGlobal["$mvRightAction"] = val * movementSpeed;
            }


        [Torque_Decorations.TorqueCallBack("", "", "moveforward", "(val)", 1, 11001, false)]
        public void moveforward(int val)
            {
            //console.SetVar("$mvForwardAction", val.AsInt() * movementSpeed);
            iGlobal["$mvForwardAction"] = val * movementSpeed;
            }


        [Torque_Decorations.TorqueCallBack("", "", "movebackward", "(val)", 1, 11001, false)]
        public void movebackward(int val)
            {
            iGlobal["$mvBackwardAction"] = val * movementSpeed;
            //console.SetVar("$mvBackwardAction", val.AsInt() * movementSpeed);
            }

        [Torque_Decorations.TorqueCallBack("", "", "moveup", "(val)", 1, 11001, false)]
        public void moveup(int val)
            {
            coSimObject obj = ((coGameConnection)"ServerConnection").getControlObject();
            if (obj.isInNamespaceHierarchy("Camera"))
                iGlobal["$mvUpAction"] = val * movementSpeed;
            //console.SetVar("$mvUpAction", val.AsInt() * movementSpeed);
            }

        [Torque_Decorations.TorqueCallBack("", "", "movedown", "(val)", 1, 11001, false)]
        public void movedown(int val)
            {
            coSimObject obj = ((coGameConnection)"ServerConnection").getControlObject();
            if (obj.isInNamespaceHierarchy("Camera"))
                iGlobal["$mvDownAction"] = val * movementSpeed;
            //console.SetVar("$mvDownAction", val.AsInt() * movementSpeed);
            }

        [Torque_Decorations.TorqueCallBack("", "", "turnLeft", "(val)", 1, 11001, false)]
        public void turnLeft(bool val)
            {
            iGlobal["$mvYawRightSpeed"] = val ? iGlobal["$Pref::Input::KeyboardTurnSpeed"] : 0;
            //console.SetVar("$mvYawRightSpeed", val.AsBool() ? console.GetVarInt("$Pref::Input::KeyboardTurnSpeed") : 0);
            }

        [Torque_Decorations.TorqueCallBack("", "", "turnRight", "(val)", 1, 11001, false)]
        public void turnRight(bool val)
            {
            //console.SetVar("$mvYawLeftSpeed", val.AsBool() ? console.GetVarInt("$Pref::Input::KeyboardTurnSpeed") : 0);
            iGlobal["$mvYawLeftSpeed"] = val ? iGlobal["$Pref::Input::KeyboardTurnSpeed"] : 0;
            }


        [Torque_Decorations.TorqueCallBack("", "", "panUp", "(val)", 1, 11001, false)]
        public void panUp(bool val)
            {
            iGlobal["$mvPitchDownSpeed"] = val ? iGlobal["$Pref::Input::KeyboardTurnSpeed"] : 0;
            //console.SetVar("$mvPitchDownSpeed", val.AsBool() ? console.GetVarInt("$Pref::Input::KeyboardTurnSpeed") : 0);
            }

        [Torque_Decorations.TorqueCallBack("", "", "panDown", "(val)", 1, 11001, false)]
        public void panDown(bool val)
            {
            iGlobal["$mvPitchUpSpeed"] = val ? iGlobal["$Pref::Input::KeyboardTurnSpeed"] : 0;
            //console.SetVar("$mvPitchUpSpeed", val.AsBool() ? console.GetVarInt("$Pref::Input::KeyboardTurnSpeed") : 0);
            }

        [Torque_Decorations.TorqueCallBack("", "", "getMouseAdjustAmount", "(val)", 1, 11001, false)]
        public float getMouseAdjustAmount(float val)
            {
            return ((val * (fGlobal["$cameraFov"] / 90.0f) * 0.01f) * fGlobal["$pref::Input::LinkMouseSensitivity"]);
            //return ((val.AsDouble() * (console.GetVarFloat("$cameraFov") / 90.0) * 0.01) * console.GetVarFloat("$pref::Input::LinkMouseSensitivity")).AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "", "getGamepadAdjustAmount", "(val)", 1, 11001, false)]
        public float getGamepadAdjustAmount(float val)
            {
            return ((val * (fGlobal["$cameraFov"] / 90.0f) * 0.01f) * 10.0f);
            //return ((val.AsFloat() * (console.GetVarFloat("$cameraFov") / 90) * 0.01) * 10.0).AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "", "yaw", "(val)", 1, 11001, false)]
        public void yaw(float val)
            {
            float yawAdj = getMouseAdjustAmount(val);
            if (((coGameConnection)"ServerConnection").isControlObjectRotDampedCamera())
                {
                yawAdj = Util.mClamp(yawAdj, (-Util.m2Pi() + (float)0.01), (Util.m2Pi() - (float)0.01));
                yawAdj *= (float)0.5;
                }
            fGlobal["$mvYaw"] = fGlobal["$mvYaw"] + yawAdj;
            //console.SetVar("$mvYaw", console.GetVarFloat("$mvYaw") + yawAdj);
            }

        [Torque_Decorations.TorqueCallBack("", "", "pitch", "(val)", 1, 11001, false)]
        public void pitch(float val)
            {
            float pitchAdj = getMouseAdjustAmount(val);
            if (((coGameConnection)"ServerConnection").isControlObjectRotDampedCamera())
                {
                pitchAdj = Util.mClamp(pitchAdj, (-Util.m2Pi() + (float)0.01), (Util.m2Pi() - (float)0.01));
                pitchAdj *= (float)0.5;
                }
            fGlobal["$mvPitch"] = fGlobal["$mvPitch"] + pitchAdj;
            //console.SetVar("$mvPitch", console.GetVarFloat("$mvPitch") + pitchAdj);
            }

        [Torque_Decorations.TorqueCallBack("", "", "jump", "(val)", 1, 11001, false)]
        public void Jump(string val)
            {
            iGlobal["$mvTriggerCount2"] = iGlobal["$mvTriggerCount2"] + 1;
            //console.SetVar("$mvTriggerCount2", console.GetVarInt("$mvTriggerCount2") + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamePadMoveX", "(val)", 1, 11001, false)]
        public void gamePadMoveX(double val)
            {
            if (val > 0)
                {
                dGlobal["$mvRightAction"] = val * movementSpeed;
                dGlobal["$mvLeftAction"] = 0;
                //console.SetVar("$mvRightAction", (val * movementSpeed).AsString());
                //console.SetVar("$mvLeftAction", 0);
                }
            else
                {
                dGlobal["$mvRightAction"] = 0;
                dGlobal["$mvLeftAction"] = -val * movementSpeed;
                //console.SetVar("$mvRightAction", 0);
                //console.SetVar("$mvLeftAction", (-val * movementSpeed).AsString());
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamePadMoveY", "(val)", 1, 11001, false)]
        public void gamePadMoveY(double val)
            {
            if (val > 0)
                {
                dGlobal["$mvForwardAction"] = val * movementSpeed;
                dGlobal["$mvBackwardAction"] = 0;
                //console.SetVar("$mvForwardAction", val.AsDouble() * movementSpeed);
                //console.SetVar("$mvBackwardAction", 0);
                }
            else
                {
                dGlobal["$mvForwardAction"] = 0;
                //console.SetVar("$mvForwardAction", 0);
                dGlobal["$mvBackwardAction"] = -val * movementSpeed;
                //console.SetVar("$mvBackwardAction", -val.AsDouble() * movementSpeed);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamepadYaw", "(val)", 1, 11001, false)]
        public void gamepadYaw(float val)
            {
            float yawAdj = getGamepadAdjustAmount(val);
            if (((coGameConnection)"ServerConnection").isControlObjectRotDampedCamera())
                {
                yawAdj = Util.mClamp(yawAdj, (float)(-Util.m2Pi() + 0.01), (float)(Util.m2Pi() - 0.01));
                yawAdj *= (float)0.5;
                }

            if (yawAdj > 0)
                {
                fGlobal["$mvYawLeftSpeed"] = yawAdj;
                fGlobal["$mvYawRightSpeed"] = 0;
                //console.SetVar("$mvYawLeftSpeed", yawAdj);
                //console.SetVar("$mvYawRightSpeed", 0);
                }
            else
                {
                fGlobal["$mvYawLeftSpeed"] = 0;
                //console.SetVar("$mvYawLeftSpeed", 0);
                fGlobal["$mvYawRightSpeed"] = -yawAdj;
                //console.SetVar("$mvYawRightSpeed", -yawAdj);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamepadPitch", "(val)", 1, 11001, false)]
        public void gamepadPitch(float val)
            {
            float pitchAdj = getGamepadAdjustAmount(val);
            if (((coGameConnection)"ServerConnection").isControlObjectRotDampedCamera())
                {
                pitchAdj = Util.mClamp(pitchAdj, (float)(-Util.m2Pi() + 0.01), (float)(Util.m2Pi() - 0.01));
                pitchAdj *= (float)0.5;
                }
            if (pitchAdj > 0)
                {
                fGlobal["$mvPitchDownSpeed"] = pitchAdj;
                fGlobal["$mvPitchUpSpeed"] = 0;
                //console.SetVar("$mvPitchDownSpeed", pitchAdj);
                //console.SetVar("$mvPitchUpSpeed", 0);
                }
            else
                {
                fGlobal["$mvPitchDownSpeed"] = 0;
                fGlobal["$mvPitchUpSpeed"] = -pitchAdj;
                //console.SetVar("$mvPitchDownSpeed", 0);
                //console.SetVar("$mvPitchUpSpeed", -pitchAdj);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "doCrouch", "(val)", 1, 11001, false)]
        public void doCrouch(string val)
            {
            iGlobal["$mvTriggerCount3"] += 1;
            //console.SetVar("$mvTriggerCount3", console.GetVarString("$mvTriggerCount3").AsInt() + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "doSprint", "(val)", 1, 11001, false)]
        public void doSprint(string val)
            {
            iGlobal["$mvTriggerCount5"] += 1;
            //console.SetVar("$mvTriggerCount5", console.GetVarString("$mvTriggerCount5").AsInt() + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "mouseFire", "(val)", 1, 11001, false)]
        public void mouseFire(string val)
            {
            iGlobal["$mvTriggerCount0"] += 1;
            //console.SetVar("$mvTriggerCount0", console.GetVarString("$mvTriggerCount0").AsInt() + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "altTrigger", "(val)", 1, 11001, false)]
        public void altTrigger(string val)
            {
            iGlobal["$mvTriggerCount1"] += 1;
            //console.SetVar("$mvTriggerCount1", console.GetVarString("$mvTriggerCount1").AsInt() + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamepadFire", "(val)", 1, 11001, false)]
        public void gamepadFire(double val)
            {
            if (val > .1 && !console.GetVarBool("$gamepadFireTriggered"))
                {
                bGlobal["$gamepadFireTriggered"] = true;
                //console.SetVar("$gamepadFireTriggered", true);
                //console.SetVar("$mvTriggerCount0", console.GetVarString("$mvTriggerCount0").AsInt() + 1);
                }
            else
                {
                bGlobal["$gamepadFireTriggered"] = false;
                //console.SetVar("$gamepadFireTriggered", false);
                //console.SetVar("$mvTriggerCount0", console.GetVarString("$mvTriggerCount0").AsInt() + 1);
                }
            iGlobal["$mvTriggerCount0"] += 1;
            }

        [Torque_Decorations.TorqueCallBack("", "", "gamepadAltTrigger", "(val)", 1, 11001, false)]
        public void gamepadAltTrigger(double val)
            {
            if (val > .1 && !bGlobal["$gamepadFireTriggered"])
                {
                bGlobal["$gamepadAltTriggerTriggered"] = true;
//                console.SetVar("$gamepadAltTriggerTriggered", true);
                }
            else
                {
                bGlobal["$gamepadAltTriggerTriggered"] = false;
                //console.SetVar("$gamepadAltTriggerTriggered", false);
                }
            iGlobal["$mvTriggerCount1"] += 1;
            //console.SetVar("$mvTriggerCount1", console.GetVarString("$mvTriggerCount1").AsInt() + 1);
            }

        [Torque_Decorations.TorqueCallBack("", "", "toggleZoomFOV", "(val)", 0, 11001, false)]
        public void toggleZoomFOV()
            {
            float cfov = fGlobal["$Player::CurrentFOV"] / (float)2.0;

            console.SetVar("$Player::CurrentFOV", cfov);
            fGlobal["$Player::CurrentFOV"] = cfov;

            if (cfov < 5)
                resetCurrentFOV();

            if (((coGameConnection)"ServerConnection")["zoomed"].AsBool())
                //console.GetVarBool("ServerConnection.zoomed"))

                console.Call("setFov", new[] { cfov.AsString() });
            else
                console.Call("setFov", new[] { console.GetVarString("ServerConnection.getControlCameraDefaultFov()") });
            }

        [Torque_Decorations.TorqueCallBack("", "", "resetCurrentFOV", "()", 0, 11001, false)]
        public void resetCurrentFOV()
            {
            fGlobal["$Player::CurrentFOV"] = ((coGameConnection) "ServerConnection").getControlCameraDefaultFov()/2.0f;
            //console.SetVar("$Player::CurrentFOV", console.GetVarFloat("ServerConnection.getControlCameraDefaultFov") / (float)2.0);
            }

        [Torque_Decorations.TorqueCallBack("", "", "turnOffZoom", "()", 0, 11001, false)]
        public void turnOffZoom()
            {
            console.SetVar("ServerConnection.zoomed", false);
            console.Call("setFov", new[] { ((coGameConnection)"ServerConnection").getControlCameraDefaultFov().AsString() });
            ((coGuiControl)"Reticle").setVisible(true);
            ((coGuiControl)"zoomReticle").setVisible(false);


            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "", "setZoomFOV", "()", 1, 11001, false)]
        public void setZoomFOV(bool val)
            {
            if (val)
                toggleZoomFOV();
            }

        [Torque_Decorations.TorqueCallBack("", "", "toggleZoom", "()", 1, 11001, false)]
        public void toggleZoom(bool val)
            {
            if (val)
                {
                console.SetVar("ServerConnection.zoomed", true);
                console.Call("setFov", new[] { console.GetVarString("$Player::CurrentFOV") });
                ((coGuiControl)"Reticle").setVisible(false);
                ((coGuiControl)"zoomReticle").setVisible(true);


                DOFPostEffectsetAutoFocus("DOFPostEffect", true);


                DOFPostEffectsetFocusParams("DOFPostEffect", 0.5f, 0.5f, 50f, 500f, -5f, 5f);

                ((coPostEffect)"DOFPostEffect").enable();
                //console.Call("DOFPostEffect", "enabled");
                }
            else
                turnOffZoom();
            }

        [Torque_Decorations.TorqueCallBack("", "", "mouseButtonZoom", "(val)", 1, 11001, false)]
        public void mouseButtonZoom(bool val)
            {
            toggleZoom(val);
            }

        [Torque_Decorations.TorqueCallBack("", "", "toggleFreeLook", "(val)", 1, 11001, false)]
        public void toggleFreeLook(bool val)
            {
            bGlobal["$mvFreeLook"] = val;
            //console.SetVar("$mvFreeLook", val);
            }

        [Torque_Decorations.TorqueCallBack("", "", "toggleFirstPerson", "(val)", 1, 11001, false)]
        public void toggleFirstPerson(bool val)
            {
            if (val)
                {
                coGameConnection ServerConnection = "ServerConnection";
                ServerConnection.setFirstPerson(ServerConnection.isFirstPerson());
                //((coGameConnection) "ServerConnection").setFirstPerson(!((coGameConnection) "ServerConnection").isFirstPerson());
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "toggleCamera", "(val)", 1, 11001, false)]
        public void toggleCamera(bool val)
            {
            if (val)
                console.commandToServer("ToggleCamera");
            }

        [Torque_Decorations.TorqueCallBack("", "", "unmountWeapon", "(val)", 1, 11001, false)]
        public void unmountWeapon(bool val)
            {
            if (val)
                console.commandToServer("unmountWeapon");
            }

        [Torque_Decorations.TorqueCallBack("", "", "throwWeapon", "(val)", 1, 11001, false)]
        public void throwWeapon(bool val)
            {
            if (val)
                console.commandToServer("Throw", new[] { "Weapon" });
            }

        [Torque_Decorations.TorqueCallBack("", "", "tossAmmo", "(val)", 1, 11001, false)]
        public void tossAmmo(bool val)
            {
            if (val)
                console.commandToServer("Throw", new[] { "Ammo" });
            }


        [Torque_Decorations.TorqueCallBack("", "", "nextWeapon", "(val)", 1, 11001, false)]
        public void nextWeapon(bool val)
            {
            if (val)
                console.commandToServer("cycleWeapon", new[] { "next" });
            }

        [Torque_Decorations.TorqueCallBack("", "", "prevWeapon", "(val)", 1, 11001, false)]
        public void prevWeapon(bool val)
            {
            if (val)
                console.commandToServer("cycleWeapon", new[] { "prev" });
            }

        [Torque_Decorations.TorqueCallBack("", "", "mouseWheelWeaponCycle", "(val)", 1, 11001, false)]
        public void mouseWheelWeaponCycle(double val)
            {
            if (val < 0)
                console.commandToServer("cycleWeapon", new[] { "next" });
            else if (val > 0)
                console.commandToServer("cycleWeapon", new[] { "prev" });
            }

        [Torque_Decorations.TorqueCallBack("", "", "pageMessageHudUp", "(val)", 1, 11001, false)]
        public void pageMessageHudUp(bool val)
            {
            if (val)
                PageUpMessageHud();
            }

        [Torque_Decorations.TorqueCallBack("", "", "pageMessageHudDown", "(val)", 1, 11001, false)]
        public void pageMessageHudDown(bool val)
            {
            if (val)
                PageDownMessageHud();
            }

        [Torque_Decorations.TorqueCallBack("", "", "resizeMessageHud", "(val)", 1, 11001, false)]
        public void resizeMessageHud(bool val)
            {
            if (val)
                CycleMessageHudSize();
            }

        [Torque_Decorations.TorqueCallBack("", "", "startRecordingDemo", "(val)", 1, 11001, false)]
        public void startRecordingDemo(bool val)
            {
            if (val)
                StartDemoRecord();
            }

        [Torque_Decorations.TorqueCallBack("", "", "stopRecordingDemo", "(val)", 1, 11001, false)]
        public void stopRecordingDemo(bool val)
            {
            if (val)
                StopDemoRecord();
            }

        [Torque_Decorations.TorqueCallBack("", "", "dropCameraAtPlayer", "(val)", 1, 11001, false)]
        public void dropCameraAtPlayer(bool val)
            {
            if (val)
                console.commandToServer("dropCameraAtPlayer");
            }

        [Torque_Decorations.TorqueCallBack("", "", "dropPlayerAtCamera", "(val)", 1, 11001, false)]
        public void dropPlayerAtCamera(bool val)
            {
            if (val)
                console.commandToServer("DropPlayerAtCamera");
            }

        [Torque_Decorations.TorqueCallBack("", "", "bringUpOptions", "(val)", 1, 11001, false)]
        public void bringUpOptions(bool val)
            {
            if (val)
                {
                showCursor();
                ((coGuiCanvas)"Canvas").pushDialog("OptionsDlg");
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "cycleDebugRenderMode", "(val)", 1, 11001, false)]
        public void cycleDebugRenderMode(bool val)
            {
            if (!val)
                return;
            iGlobal["$MFDebugRenderMode"] += 1;
            //console.SetVar("$MFDebugRenderMode", console.GetVarInt("$MFDebugRenderMode") + 1);

            if (iGlobal["$MFDebugRenderMode"] > 16)
                 iGlobal["$MFDebugRenderMode"]= 0;
            if (iGlobal["$MFDebugRenderMode"] == 15)
                 iGlobal["$MFDebugRenderMode"]= 16;

            Util.setInteriorRenderMode(console.GetVarInt("$MFDebugRenderMode"));

            if (!console.isObject("ChatHud"))
                return;
            string message = "Setting Interior debug render mode to ";
            string debugMode = "Unknown";
            switch (iGlobal["$MFDebugRenderMode"])
                {
                case 0:
                    debugMode = "NormalRender";
                    break;
                case 1:
                    debugMode = "NormalRenderLines";
                    break;
                case 2:
                    debugMode = "ShowDetail";
                    break;
                case 3:
                    debugMode = "ShowAmbiguous";
                    break;
                case 4:
                    debugMode = "ShowOrphan";
                    break;
                case 5:
                    debugMode = "ShowLightmaps";
                    break;
                case 6:
                    debugMode = "ShowTexturesOnly";
                    break;
                case 7:
                    debugMode = "ShowPortalZones";
                    break;
                case 8:
                    debugMode = "ShowOutsideVisible";
                    break;
                case 9:
                    debugMode = "ShowCollisionFans";
                    break;
                case 10:
                    debugMode = "ShowStrips";
                    break;
                case 11:
                    debugMode = "ShowNullSurfaces";
                    break;
                case 12:
                    debugMode = "ShowLargeTextures";
                    break;
                case 13:
                    debugMode = "ShowHullSurfaces";
                    break;
                case 14:
                    debugMode = "ShowVehicleHullSurfaces";
                    break;
                case 15:
                    debugMode = "";
                    break;
                case 16:
                    debugMode = "ShowDetailLevel";
                    break;
                }
            ChatHudAddLine("ChatHud", message + debugMode);
            }

        [Torque_Decorations.TorqueCallBack("", "", "doProfile", "(val)", 1, 11001, false)]
        public void doProfile(bool val)
            {
            if (val)
                {
                console.print("Starting profile session...");
                Util.profilerReset();
                Util.profilerEnable(true);
                }
            else
                {
                console.print("Ending profile session...");
                Util.profilerDumpToFile("profilerDumpToFile" + console.Call("getSimTime") + ".txt");
                Util.profilerEnable(false);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "carjack", "()", 0, 11001, false)]
        public void carjack()
            {
            coPlayer player = ((coGameConnection)"LocalClientConnection").getControlObject();
            if (console.GetClassName(player) != "Player")
                return;
            Point3F eyeVec = player.getEyeVector();

            Point3F startPos = player.getEyePoint();

            Point3F endPos = startPos + eyeVec.vectorScale(1000);

            coPlayer target = Util.containerRayCast(startPos, endPos, (uint)SceneObjectTypesAsUint.VehicleObjectType, "", false);
            if (!target.isObject())
                return;
            int mount = target.getMountNodeObject(0);
            if (mount.AsBool() && console.GetClassName(mount.AsString()) == "AIPlayer")
                console.commandToServer("carUnmountObj", new[] { mount.AsString() });
            }

        [Torque_Decorations.TorqueCallBack("", "", "getOut", "()", 0, 11001, false)]
        public void getOut()
            {
            ((coActionMap)"vehicleMap").pop();
            ((coActionMap)"moveMap").push();
            console.commandToServer("dismountVehicle");
            }

        [Torque_Decorations.TorqueCallBack("", "", "brakeLights", "()", 0, 11001, false)]
        public void brakeLights()
            {
            console.commandToServer("toggleBrakeLights");
            }

        [Torque_Decorations.TorqueCallBack("", "", "brake", "(val)", 1, 11001, false)]
        public void brake(string val)
            {
            console.commandToServer("toggleBrakeLights");
            iGlobal["$mvTriggerCount2"] += 1;
            //console.SetVar("$mvTriggerCount2", console.GetVarInt("$mvTriggerCount2") + 1);
            }


        [Torque_Decorations.TorqueCallBack("", "", "init_Default_Bind1", "()", 0, 11004, true)]
        public void init_Default_Bind()
            {
            coActionMap moveMap = "moveMap";

            moveMap.bind("keyboard", "F2", "showPlayerList");
            moveMap.bind("keyboard", "h", "showControlsHelp");
            moveMap.bind("keyboard", "ctrl h", "hideHUDs");
            moveMap.bind("keyboard", "alt p", "doScreenShotHudless");
            moveMap.bind("keyboard", "a", "moveleft");
            moveMap.bind("keyboard", "d", "moveright");
            moveMap.bind("keyboard", "left", "moveleft");
            moveMap.bind("keyboard", "right", "moveright");
            moveMap.bind("keyboard", "w", "moveforward");
            moveMap.bind("keyboard", "s", "movebackward");
            moveMap.bind("keyboard", "up", "moveforward");
            moveMap.bind("keyboard", "down", "movebackward");
            moveMap.bind("keyboard", "e", "moveup");
            moveMap.bind("keyboard", "c", "movedown");
            moveMap.bind("keyboard", "space", "jump");
            moveMap.bind("mouse", "xaxis", "yaw");
            moveMap.bind("mouse", "yaxis", "pitch");
            moveMap.bind("mouse", "button0", "mouseFire");
            moveMap.bind("mouse", "button1", "mouseButtonZoom");
            moveMap.bind("mouse", "zaxis", "mouseWheelWeaponCycle");
            moveMap.bind("gamepad", "thumbrx", "D", "-0.23 0.23", "gamepadYaw");
            moveMap.bind("gamepad", "thumbry", "D", "-0.23 0.23", "gamepadPitch");
            moveMap.bind("gamepad", "thumblx", "D", "-0.23 0.23", "gamePadMoveX");
            moveMap.bind("gamepad", "thumbly", "D", "-0.23 0.23", "gamePadMoveY");
            moveMap.bind("gamepad", "btn_a", "jump");
            moveMap.bind("keyboard", "lcontrol", "doCrouch");
            moveMap.bind("gamepad", "btn_b", "doCrouch");
            moveMap.bind("keyboard", "lshift", "doSprint");
            moveMap.bind("gamepad", "triggerr", "gamepadFire");
            moveMap.bind("gamepad", "triggerl", "gamepadAltTrigger");
            moveMap.bind("keyboard", "f", "setZoomFOV");
            moveMap.bind("keyboard", "z", "toggleZoom");
            moveMap.bind("keyboard", "v", "toggleFreeLook");
            moveMap.bind("keyboard", "tab", "toggleFirstPerson");
            moveMap.bind("keyboard", "alt c", "toggleCamera");
            moveMap.bind("gamepad", "btn_start", "toggleCamera");
            moveMap.bind("gamepad", "btn_x", "toggleFirstPerson");
            moveMap.bind("keyboard", "0", "unmountWeapon");
            moveMap.bind("keyboard", "alt w", "throwWeapon");
            moveMap.bind("keyboard", "alt a", "tossAmmo");
            moveMap.bind("keyboard", "q", "nextWeapon");
            moveMap.bind("keyboard", "ctrl q", "prevWeapon");
            moveMap.bind("keyboard", "u", "toggleMessageHud");
            moveMap.bind("keyboard", "pageUp", "pageMessageHudUp");
            moveMap.bind("keyboard", "pageDown", "pageMessageHudDown");
            moveMap.bind("keyboard", "p", "resizeMessageHud");
            moveMap.bind("keyboard", "F3", "startRecordingDemo");
            moveMap.bind("keyboard", "F4", "stopRecordingDemo");
            moveMap.bind("keyboard", "F8", "dropCameraAtPlayer");
            moveMap.bind("keyboard", "F7", "dropPlayerAtCamera");


            moveMap.bindCmd("keyboard", "escape", "", "handleEscape();");
            moveMap.bindCmd("gamepad", "btn_back", "disconnect();", "");
            moveMap.bindCmd("gamepad", "dpadl", "toggleLightColorViz();", "");
            moveMap.bindCmd("gamepad", "dpadu", "toggleDepthViz();", "");
            moveMap.bindCmd("gamepad", "dpadd", "toggleNormalsViz();", "");
            moveMap.bindCmd("gamepad", "dpadr", "toggleLightSpecularViz();", "");
            moveMap.bindCmd("keyboard", "ctrl k", "commandToServer('suicide');", "");
            moveMap.bindCmd("keyboard", "1", "commandToServer('use',\"Ryder\");", "");
            moveMap.bindCmd("keyboard", "2", "commandToServer('use',\"Lurker\");", "");
            moveMap.bindCmd("keyboard", "3", "commandToServer('use',\"LurkerGrenadeLauncher\");", "");
            moveMap.bindCmd("keyboard", "4", "commandToServer('use',\"ProxMine\");", "");
            moveMap.bindCmd("keyboard", "5", "commandToServer('use',\"DeployableTurret\");", "");
            moveMap.bindCmd("keyboard", "r", "commandToServer('reloadWeapon');", "");
            moveMap.bindCmd("keyboard", "n", "toggleNetGraph();", "");
            moveMap.bindCmd("keyboard", "ctrl z", "carjack();", "");

            coActionMap GlobalActionMap = "GlobalActionMap";

            GlobalActionMap.bind("keyboard", "ctrl o", "bringUpOptions");
            GlobalActionMap.bind("keyboard", "F9", "cycleDebugRenderMode");
            GlobalActionMap.bind("keyboard", "ctrl F3", "doProfile");
            GlobalActionMap.bind("keyboard", "tilde", "toggleConsole");
            GlobalActionMap.bindCmd("keyboard", "alt k", "cls();", "");
            GlobalActionMap.bindCmd("keyboard", "alt enter", "", "Canvas.attemptFullscreenToggle();");
            GlobalActionMap.bindCmd("keyboard", "F1", "", "contextHelp();");

            coActionMap vehicleMap = "vehicleMap";
            vehicleMap.bindCmd("keyboard", "ctrl x", "commandToServer(\'flipCar\');", "");
            vehicleMap.bindCmd("keyboard", "ctrl f", "getout();", "");
            vehicleMap.bindCmd("keyboard", "l", "brakeLights();", "");
            vehicleMap.bindCmd("keyboard", "escape", "", "handleEscape();");
            vehicleMap.bind("keyboard", "w", "moveforward");
            vehicleMap.bind("keyboard", "s", "movebackward");
            vehicleMap.bind("keyboard", "up", "moveforward");
            vehicleMap.bind("keyboard", "down", "movebackward");
            vehicleMap.bind("mouse", "xaxis", "yaw");
            vehicleMap.bind("mouse", "yaxis", "pitch");
            vehicleMap.bind("mouse", "button0", "mouseFire");
            vehicleMap.bind("mouse", "button1", "altTrigger");
            vehicleMap.bind("keyboard", "space", "brake");
            vehicleMap.bind("keyboard", "h", "showControlsHelp");
            vehicleMap.bind("keyboard", "v", "toggleFreeLook");
            vehicleMap.bind("keyboard", "alt c", "toggleCamera");
            }
        }
    }