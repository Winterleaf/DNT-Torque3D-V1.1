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

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    public partial class Main : TorqueScriptTemplate
        {
        //-----------------------------------------------------------------------------
        // Misc. server commands avialable to clients
        //-----------------------------------------------------------------------------

        //----------------------------------------------------------------------------
        // Debug commands
        //----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "", "serverCmdNetSimulateLag", "( %client, %msDelay, %packetLossPercent )", 3, 12000, false)]
        public void ServerCmdNetSimulateLag(coGameConnection client, int msDelay, float packetLossPercent)
            {
            if (client["isAdmin"].AsBool())
                client.setSimulatedNetParams((packetLossPercent/100.0f), msDelay);
            }

        //----------------------------------------------------------------------------
        // Camera commands
        //----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "", "serverCmdTogglePathCamera", "(%client, %val)", 2, 12000, false)]
        public void ServerCmdTogglePathCamera(coGameConnection client, bool val)
            {
            string control = val ? client["PathCamera"] : client["camera"];

            client.setControlObject(control);

            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdToggleCamera", "(%client)", 1, 12000, false)]
        public void ServerCmdToggleCamera(coGameConnection client)
            {
            string control;
            if (client.getControlObject() == client["player"])
                {
                new coCamera(client["camera"]).setVelocity(new Point3F("0 0 0"));
                control = client["camera"];
                }
            else
                {
                new coCamera(client["player"]).setVelocity(new Point3F("0 0 0"));
                control = client["player"];
                }
            client.setControlObject(control);

            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorCameraPlayer", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorCameraPlayer(coGameConnection client)
            {
            new coPlayer(client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(true);
            bGlobal["$isFirstPersonVar"] = true;
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorCameraPlayerThird", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorCameraPlayerThird(coGameConnection client)
            {
            new coPlayer(client["player"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["player"]);
            client.setFirstPerson(false);
            bGlobal["$isFirstPersonVar"] = false;
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdDropPlayerAtCamera", "(%client)", 1, 12000, false)]
        public void ServerCmdDropPlayerAtCamera(coGameConnection client)
            {
            // If the player is mounted to something (like a vehicle) drop that at the
            // camera instead. The player will remain mounted.
            coPlayer player = client["player"];
            coShapeBase obj = null;

            obj = player.getObjectMount();
            if (!console.isObject(obj))
                obj = client["player"];

            obj.setTransform(new coCamera(client["Camera"]).getTransform());
            obj.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(player);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdDropCameraAtPlayer", "(%client)", 1, 12000, false)]
        public void ServerCmdDropCameraAtPlayer(coGameConnection client)
            {
            coPlayer player = client["player"];
            new coCamera(client["camera"]).setTransform(player.getTransform());
            new coCamera(client["camera"]).setVelocity(new Point3F("0 0 0"));
            client.setControlObject(client["camera"]);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdCycleCameraFlyType", "(%client)", 1, 12000, false)]
        public void ServerCmdCycleCameraFlyType(coGameConnection client)
            {
            coCamera camera = client["camera"];
            if (camera.getMode() != Camera__CameraMotionMode.FlyMode)
                return;
            if (camera["newtonMode"].AsBool() == false)
                {
                camera["newtonMode"] = true.AsString();
                camera["newtonRotation"] = false.AsString();
                camera.setVelocity(new Point3F("0 0 0"));
                }
            else if (camera["newtonRotation"].AsBool() == false)
                {
                camera["newtonMode"] = true.AsString();
                camera["newtonRotation"] = true.AsString();
                camera.setAngularVelocity(new Point3F("0 0 0"));
                }
            else
                {
                camera["newtonMode"] = false.AsString();
                camera["newtonRotation"] = false.AsString();
                }
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorCameraStandard", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorCameraStandard(coGameConnection client)
            {
            coCamera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = true.AsString();
            camera["newtonRotation"] = false.AsString();
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorCameraNewton", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorCameraNewton(coGameConnection client)
            {
            coCamera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = true.AsString();
            camera["newtonRotation"] = false.AsString();
            camera.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorCameraNewtonDamped", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorCameraNewtonDamped(coGameConnection client)
            {
            coCamera camera = client["camera"];
            camera.setFlyMode();
            camera["newtonMode"] = true.AsString();
            camera["newtonRotation"] = true.AsString();
            camera.setVelocity(new Point3F("0 0 0"));
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorOrbitCamera", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorOrbitCamera(coGameConnection client)
            {
            coCamera camera = client["camera"];
            camera.setEditOrbitMode();
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSetEditorFlyCamera", "(%client)", 1, 12000, false)]
        public void ServerCmdSetEditorFlyCamera(coGameConnection client)
            {
            coCamera camera = client["camera"];
            camera.setFlyMode();
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdEditorOrbitCameraSelectChange", "(%client, %size, %center)", 3, 12000, false)]
        public void ServerCmdEditorOrbitCameraSelectChange(coGameConnection client, int size, Point3F center)
            {
            coCamera camera = client["camera"];
            if (size > 0)
                {
                camera.setValidEditOrbitPoint(true);
                camera.setEditOrbitPoint(center);
                }
            else
                camera.setValidEditOrbitPoint(false);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdEditorCameraAutoFit", "(%client, %radius)", 2, 12000, false)]
        public void ServerCmdEditorCameraAutoFit(coGameConnection client, float radius)
            {
            coCamera camera = client["camera"];
            camera.autoFitRadius(radius);
            client.setControlObject(camera);
            console.Call("clientCmdSyncEditorGui");
            }

        //----------------------------------------------------------------------------
        // Server admin
        //----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSAD", "( %client, %password )", 2, 12000, false)]
        public void ServerCmdSAD(coGameConnection client, string password)
            {
            if (password == "" || password != sGlobal["$Pref::Server::AdminPassword"])
                return;
            client["isAdmin"] = true.AsString();
            client["isSuperAdmin"] = true.AsString();


            string name = console.getTaggedString(client["playerName"]);
            MessageAll("MsgAdminForce", console.ColorEncode(string.Format(@"\c2{0} has become Admin by force.", name)), client);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSADSetPassword", "( %client, %password )", 2, 12000, false)]
        public void ServerCmdSADSetPassword(coGameConnection client, string password)
            {
            if (client["isSuperAdmin"].AsBool())
                sGlobal["$Pref::Server::AdminPassword"] = password;
            }

        //----------------------------------------------------------------------------
        // Server chat message handlers
        //----------------------------------------------------------------------------
        [Torque_Decorations.TorqueCallBack("", "", "serverCmdTeamMessageSent", "(%client, %text)", 2, 12000, false)]
        public void ServerCmdTeamMessageSent(coGameConnection client, string text)
            {
            if (text.Trim().Length >= iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, iGlobal["$Pref::Server::MaxChatLen"]);
            ChatMessageTeam(client, client["team"], console.ColorEncode(@"\c3%1: %2"), client["playerName"], text);
            }

        [Torque_Decorations.TorqueCallBack("", "", "ServerCmdMessageSent", "(%client, %text)", 2, 12000, false)]
        public void ServerCmdMessageSent(coGameConnection client, string text)
            {
            if (text.Trim().Length >= iGlobal["$Pref::Server::MaxChatLen"])
                text = text.Substring(0, iGlobal["$Pref::Server::MaxChatLen"]);
            ChatMessageAll(client, console.ColorEncode(@"\c4%1: %2"), client["playerName"], text);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdSuicide", "(%client)", 1, 100, false)]
        public void ServerCmdSuicide(coGameConnection client)
            {
            if (console.isObject(client))
                PlayerKill(client["player"], "Suicide");
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdPlayCel", "(%client,%anim)", 2, 100, false)]
        public void ServerCmdPlayCel(coGameConnection client, string anim)
            {
            if (console.isObject(client))
                PlayerPlayCelAnimation(client["player"], anim);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdTestAnimation", "(%client,%anim)", 2, 100, false)]
        public void ServerCmdTestAnimation(coGameConnection client, string anim)
            {
            if (console.isObject(client))
                new coPlayer(client["player"]).call("playTestAnimation", anim);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdPlayDeath", "(%client)", 1, 100, false)]
        public void ServerCmdPlayDeath(coGameConnection client, string anim)
            {
            if (console.isObject(client))
                PlayerPlayDeathAnimation(client["player"]);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdThrow", "(%client, %data))", 2, 100, false)]
        public void ServerCmdThrow(coGameConnection client, string data)
            {
            coPlayer player = client["player"];

            if (!console.isObject(player) || (player.getState() == "Dead") || !Game_Running)
                return;

            coSimObject mountedimage = player.getMountedImage(iGlobal["$WeaponSlot"]);
            switch (data)
                {
                    case "Weapon":
                        {
                        if (mountedimage != "0")
                            {
                            coItemData item = mountedimage["item"];
                            ShapeBaseShapeBaseThrow(player, item);
                            }
                        }
                        break;
                    case "Ammo":
                        {
                        if (mountedimage != "0")
                            {
                            coSimObject item = mountedimage;
                            if (item["ammo"] != "")
                                ShapeBaseShapeBaseThrow(player, new coItemData(item["ammo"]));
                            }
                        }
                        break;
                    default:
                        if (ShapeBaseShapeBaseHasInventory(player, new coItemData(new coSimObject(data).getName())))
                            ShapeBaseShapeBaseThrow(player, new coItemData(data));
                        break;
                }
            }


        [Torque_Decorations.TorqueCallBack("", "", "serverCmdCycleWeapon", "(%client, %direction)", 2, 100, false)]
        public void ServerCmdCycleWeapon(coGameConnection client, string direction)
            {
            ShapeBaseCycleWeapon(new coShapeBase(client.getControlObject()), direction);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdUnmountWeapon", "(%client)", 1, 100, false)]
        public void ServerCmdUnmountWeapon(coGameConnection client)
            {
            ((coPlayer) client["player"]).unmountImage(iGlobal["$WeaponSlot"]);
            //ShapeBase.unmountImage(client, iGlobal["$WeaponSlot"]);
            }

        [Torque_Decorations.TorqueCallBack("", "", "serverCmdReloadWeapon", "(%client)", 1, 100, false)]
        public void ServerCmdReloadWeapon(coGameConnection client)
            {
            coPlayer player = client.getControlObject();

            coItemData image = player.getMountedImage(iGlobal["$WeaponSlot"]);

            if (ShapeBaseShapeBaseGetInventory(player, image["ammo"]) == image["ammo.maxInventory"].AsInt())
                {
                return;
                }

            if (image > 0)
                WeaponImageClearAmmoClip(image, player, sGlobal["$WeaponSlot"].AsInt());
            }
        }
    }