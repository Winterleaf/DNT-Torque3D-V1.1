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
using System.Collections.Generic;
using WinterLeaf.Classes;
using WinterLeaf.Containers;
using WinterLeaf.Enums;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    //-----------------------------------------------------------------------------
    // Torque
    // Copyright GarageGames, LLC 2011
    //-----------------------------------------------------------------------------

    // // Damage Rate for entering Liquid
    // $DamageLava = 0.01;
    // $DamageHotLava = 0.01;
    // $DamageCrustyLava = 0.01;

    public partial class Main : TorqueScriptTemplate
        {
        [Torque_Decorations.TorqueCallBack("", "", "Player_Init_Globals", "", 0, 2400, true)]
        public void PlayerInitGlobals()
            {
            iGlobal["$CorpseTimeoutValue"] = 45 * 1000;
            iGlobal["$PlayerDeathAnim::TorsoFrontFallForward"] = 1;
            iGlobal["$PlayerDeathAnim::TorsoFrontFallBack"] = 2;
            iGlobal["$PlayerDeathAnim::TorsoBackFallForward"] = 3;
            iGlobal["$PlayerDeathAnim::TorsoLeftSpinDeath"] = 4;
            iGlobal["$PlayerDeathAnim::TorsoRightSpinDeath"] = 5;
            iGlobal["$PlayerDeathAnim::LegsLeftGimp"] = 6;
            iGlobal["$PlayerDeathAnim::LegsRightGimp"] = 7;
            iGlobal["$PlayerDeathAnim::TorsoBackFallForward"] = 8;
            iGlobal["$PlayerDeathAnim::HeadFrontDirect"] = 9;
            iGlobal["$PlayerDeathAnim::HeadBackFallForward"] = 10;
            iGlobal["$PlayerDeathAnim::ExplosionBlowBack"] = 11;
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onAdd", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnAdd(coPlayerData datablock, coPlayer player)
            {
            player["mountVehicle"] = true.AsString();
            player.setRechargeRate(datablock["rechargeRate"].AsFloat());
            player.setRepairRate(0);
            //player.schedule("50", "updateHealth");
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onRemove", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnRemove(coPlayerData datablock, coPlayer player)
            {
            if (player["client.player"] == player)
                player["client.player"] = "0";
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onNewDataBlock", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnNewDataBlock(coPlayerData datablock, coPlayer player)
            {
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onMount", "(%this, %obj, %vehicle, %node)", 4, 2400, false)]
        public void ArmorOnMount(coPlayerData datablock, coPlayer player, coVehicle vehicle, int node)
            {
            coVehicleData vehicleDataBlock = vehicle.getDataBlock();
            if (node == 0)
                {
                player.setTransform(new TransformF("0 0 0 0 0 1 0"));


                string mountPose = vehicleDataBlock["mountPose[" + node + "]"];
                player.setActionThread(mountPose, true, true);

                player["lastWeapon"] = player.getMountedImage(WeaponSlot).AsString();


                coGameConnection client = player["client"];
                if (client.isObject())
                    player["lastperson"] = client.isFirstPerson().AsString();

                player.unmountImage(WeaponSlot);


                player.setControlObject(vehicle);

                if (player.getClassName() == "Player")
                    {
                    console.commandToClient(player["client"], console.addTaggedString("toggleVehicleMap"), new[] { "true" });
                    }
                }
            else
                {
                string pose = vehicleDataBlock["mountPose[" + node + "]"];
                player.setActionThread(pose != "" ? pose : "root", false, true);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onUnmount", "(%this, %obj, %vehicle, %node)", 4, 2400, false)]
        public void ArmorOnUnmount(coPlayerData datablock, coPlayer player, coVehicle vehicle, int node)
            {
            if (node != 0)
                return;

            player.mountImage(player["lastWeapon"], WeaponSlot, true, "");
            player.setControlObject("");

            if (!player["lastperson"].AsBool())
                return;

            coGameConnection client = player["client"];
            if (client.isObject())
                client.setFirstPerson(player["lastperson"].AsBool());
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "doDismount", "(%this, %obj,%forced)", 3, 2400, false)]
        public void ArmorDoDismount(coPlayerData datablock, coPlayer player, bool forced)
            {
            coVehicle vehicle = player["mVehicle"];
            if (!vehicle.isObject())
                return;
            if (!player.isMounted())
                return;


            Point3F vvel = vehicle.getVelocity();
            coVehicleData vdb = vehicle.getDataBlock();
            int maxDismountSpeed = vdb["maxDismountSpeed"].AsInt();
            if ((vvel.len() <= maxDismountSpeed) || (forced))
                {
                TransformF pos = player.getTransform();
                TransformF rot = pos;
                TransformF oldpos = pos.copy();

                List<Point3F> vecs = new List<Point3F> { new Point3F(-1, 0, 0), new Point3F(0, 0, 1), new Point3F(0, 0, -1), new Point3F(1, 0, 0), new Point3F(0, -1, 0), new Point3F(0, 0, 0) };

                Point3F impulsevec = new Point3F(0, 0, 0);


                TransformF r = math.MatrixMulVector(player.getTransform(), vecs[0]);

                vecs[0] = r.MPosition;
                pos.MPosition.x = 0;
                pos.MPosition.y = 0;
                pos.MPosition.z = 0;

                const int numofAttempts = 5;
                int success = -1;

                for (int i = 0; i < numofAttempts; i++)
                    {
                    Point3F vectorscale = vecs[i].vectorScale(3);

                    pos = oldpos + new TransformF(vectorscale);
                    if (!player.checkDismountPoint(oldpos.MPosition, pos.MPosition))
                        continue;
                    success = i;
                    impulsevec = vecs[i].copy();
                    break;
                    }
                if ((forced) && (success == -1))
                    pos = oldpos.copy();

                player["mountVehicle"] = false.AsString();
                player.schedule("4000", "mountVehicles", "true");
                player.unmount();
                player.setTransform(new TransformF(pos.MPosition.x, pos.MPosition.y, pos.MPosition.z, rot.MOrientation.x, rot.MOrientation.y, rot.MOrientation.z, rot.MAngle));


                Point3F velo = impulsevec.vectorScale(player["mass"].AsFloat());
                velo.z = 1;

                player.applyImpulse(pos.MPosition, velo);


                Point3F vel = player.getVelocity();
                float vec = Point3F.vectorDot(vel, vel.normalizeSafe());
                if (vec > 50)
                    {
                    float scale = 50 / vec;
                    player.setVelocity(vel.vectorScale(scale));
                    }
                }
            else
                {
                MessageClient(player["client"], "msgUnmount", @"\c2Cannot exit %1 while moving.", console.GetVarString(vdb + ".nameTag"));
                }
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onCollision", "(%this, %obj,%%col)", 3, 2400, false)]
        public void ArmorOnCollision(coPlayerData datablock, coPlayer player, coShapeBase col)
            {
            if (player.getState() == "Dead")
                return;
            // Try and pickup all items
            if (col.getClassName() == "Item")
                {
                player.call("pickup", col);
                return;
                }
            //AI are not allowed to drive they are lousey drivers....
            coGameConnection client = player["client"];

            if (!client.isObject())
                return;
            //Mount Vehicle.
            if ((console.getTypeMask(col) & (UInt32)SceneObjectTypesAsUint.GameBaseObjectType) != (UInt32)SceneObjectTypesAsUint.GameBaseObjectType)
                return;
            coVehicleData db = col.getDataBlock();
            if (((db.getClassName() == "WheeledVehicleData") || player["mountVehicle"].AsBool() || player.getState() == "Move" || col["mountable"].AsBool()))
                return;
            // Only mount drivers for now.
            ((coGameConnection)player["client"]).setFirstPerson(false);
            // For this specific example, only one person can fit
            // into a vehicle
            int mount = col.getMountNodeObject(0);
            if (mount > 0)
                return;
            // For this specific FPS Example, always mount the player to node 0
            col.mountObject(player, 0, new TransformF(true));
            player["mVehicle"] = col;
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onImpact", "%this, %obj, %collidedObject, %vec, %vecLen)", 5, 2400, false)]
        public void ArmorOnImpact(coPlayerData datablock, coPlayer player, coShapeBase collidedObject, TransformF vec, float vecLen)
            {
            TransformF p = player.getTransform();
            p = p + vec;
            float speedDamageScale = vecLen + datablock["speedDamageScale"].AsFloat();

            ShapeBaseDamage(player, "0", p.MPosition, speedDamageScale, "Impact");
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "damage", "(%this, %obj, %sourceObject, %position, %damage, %damageType)", 6, 2400, false)]
        public void ArmorDamage(coPlayerData datablock, coPlayer player, TransformF position, coPlayer sourceobject, float damage, string damageType)
            {
            if (!player.isObject())
                return;
            if (player.getState() == "Dead")
                return;
            if (damage == 0.0)
                return;


            player.applyDamage(damage);

            const string location = "Body";

            //PlayerUpdateHealth(player);

            coGameConnection client = player["client"];
            //Only continue if it is a player, if it is an AI return.
            if (!client.isObject())
                return;


            coGameConnection sourceClient = null;
            if (sourceobject != 0)
                sourceClient = sourceobject["client"];


            if (player.getDamageLevel() >= 99)
                player.unmountImage(0);

            // Determine damage direction
            if (damageType != "Suicide")
                PlayerSetDamageDirection(player, sourceobject, position);

            if (player.getState() == "Dead")
                GameConnectionOnDeath(client, sourceobject, sourceClient, damageType, location);
            }


        [Torque_Decorations.TorqueCallBack("", "Armor", "ondamage", "(%this, %obj, %delta)", 3, 2400, false)]
        public void ArmorOnDamage(coPlayerData datablock, coPlayer player, float delta)
            {
            // This method is invoked by the ShapeBase code whenever the
            // object's damage level changes.
            if ((delta <= 0) || player.getState() == "Dead")
                return;
            // Apply a damage flash
            player.setDamageFlash(1);
            // If the pain is excessive, let's hear about it.
            if (delta > 10)
                PlayerPlayPain(player);
            }

        // ----------------------------------------------------------------------------
        // The player object sets the "disabled" state when damage exceeds it's
        // maxDamage value. This is method is invoked by ShapeBase state mangement code.

        // If we want to deal with the damage information that actually caused this
        // death, then we would have to move this code into the script "damage" method.
        [Torque_Decorations.TorqueCallBack("", "Armor", "onDisabled", "(%this, %obj, %state)", 3, 2400, false)]
        public void ArmorOnDisabled(coPlayerData datablock, coPlayer player, string state)
            {
            player.setImageTrigger(0, false);
            coItem item = (((coItemData)(player.getMountedImage(WeaponSlot)))["item"]);

            if (item.isObject())
                {
                int amount = ShapeBaseShapeBaseGetInventory(player, (item["image.ammo"]));

                if (amount.AsBool())
                    ShapeBaseShapeBaseThrow(player, (item["image.clip"]), 1);
                }
            ShapeBaseTossPatch(player);
            PlayerPlayDeathCry(player);
            PlayerPlayDeathAnimation(player);


            //If it's a player check.....
            coGameConnection client = player["client"];
            if (client.isObject())
                console.commandToClient(client, console.addTaggedString("toggleVehicleMap"), new[] { "false" });

            int ctov = iGlobal["$CorpseTimeoutValue"];

            player.schedule((ctov - 1000).AsString(), "startFade", "1000", "0", "true");
            player.schedule(ctov.AsString(), "delete");
            }


        [Torque_Decorations.TorqueCallBack("", "Armor", "onLeaveMissionArea", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnLeaveMissionArea(coPlayerData datablock, coPlayer player)
            {
            GameConnectionOnLeaveMissionArea(player["client"]);
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onEnterMissionArea", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnEnterMissionArea(coPlayerData datablock, coPlayer player)
            {
            GameConnectionOnEnterMissionArea(player["client"]);
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onEnterLiquid", "(%this, %obj, %coverage, %type)", 4, 2400, false)]
        public void ArmorOnEnterLiquid(coPlayerData datablock, coPlayer player, string coverage, string type)
            {
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onLeaveLiquid", "(%this, %obj, %type)", 3, 2400, false)]
        public void ArmorOnLeaveLiquid(coPlayerData datablock, coPlayer player, string type)
            {
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onTrigger", "(%this, %obj, %triggerNum, %val)", 4, 2400, false)]
        public void ArmorOnTrigger(coPlayerData datablock, coPlayer player, string triggernum, string val)
            {
            // This method is invoked when the player receives a trigger move event.
            // The player automatically triggers slot 0 and slot one off of triggers #
            // 0 & 1.  Trigger # 2 is also used as the jump key.
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onPoseChange", "(%this, %obj, %oldPose, %newPose)", 4, 2400, false)]
        public void ArmorOnPosechange(coPlayerData datablock, coPlayer player, string oldpose, string newpose)
            {
            player.setImageScriptAnimPrefix(WeaponSlot, console.addTaggedString(newpose));
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onStartSprintMotion", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnStartSprintMotion(coPlayerData datablock, coPlayer player)
            {
            player.setImageGenericTrigger(WeaponSlot, 0, true);
            }

        [Torque_Decorations.TorqueCallBack("", "Armor", "onStopSprintMotion", "(%this, %obj)", 2, 2400, false)]
        public void ArmorOnStopSprintMotion(coPlayerData datablock, coPlayer player)
            {
            player.setImageGenericTrigger(WeaponSlot, 0, false);
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "kill", "(%this, %damageType)", 2, 2400, false)]
        public void PlayerKill(coPlayer player, string damageType)
            {
            ShapeBaseDamage(player, "0", player.getTransform().MPosition, 10000, damageType);
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "mountVehicles", "(%this, %bool)", 2, 2400, false)]
        public void PlayerMountVehicles(coPlayer player, string boolvalue)
            {
            player["mountVehicle"] = boolvalue.AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "isPilot", "(%this)", 1, 2400, false)]
        public bool PlayerIsPilot(coPlayer player)
            {

            coVehicle vehicle = player.getObjectMount();
            if (vehicle.isObject())
                if (vehicle.getMountNodeObject(0) == player)
                    return true;

            return false;
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "playDeathAnimation", "(%this)", 1, 2400, false)]
        public void PlayerPlayDeathAnimation(coPlayer player)
            {
            int numDeathAnimations = player.getNumDeathAnimations();
            if (numDeathAnimations <= 0)
                return;

            coGameConnection client = player["client"];
            if (client.isObject())
                {
                int deathidx = client["deathIdx"].AsInt();
                if ((deathidx > numDeathAnimations) || (deathidx == 0))
                    {
                    deathidx = 1;
                    }
                player.setActionThread("Death" + deathidx, false, true);
                deathidx++;
                client["deathIdx"] = deathidx.AsString();
                }
            else
                {
                int r = new Random().Next(1, numDeathAnimations);
                player.setActionThread("Death" + r, false, true);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "playCelAnimation", "(%this, %anim)", 2, 2400, false)]
        public void PlayerPlayCelAnimation(coPlayer player, string anim)
            {
            if (player.getState() != "Dead")
                player.setActionThread(string.Format("cel{0}", anim), false, true);
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "playDeathCry", "(%this)", 1, 2400, false)]
        public void PlayerPlayDeathCry(coPlayer player)
            {
            player.playAudio(0, "DeathCrySound");
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "playPain", "(%this)", 1, 2400, false)]
        public void PlayerPlayPain(coPlayer player)
            {
            player.playAudio(0, "PainCrySound");
            }

        //[Torque_Decorations.TorqueCallBack("", "Player", "updateHealth", "(%player)", 1, 2400, false)]
        //public void PlayerUpdateHealth(coPlayer player)
        //    {
        //    coGameConnection client = null;

        //    client = player["client"];
        //    if (!client.isObject())
        //        return;


        //    float maxDamage = ((coPlayerData)player.getDataBlock())["maxDamage"].AsFloat();

        //    float damagelevel = player.getDamageLevel();

        //    double curhealth = maxDamage - damagelevel;

        //    curhealth = Math.Ceiling(curhealth);
        //    if (client.isObject())
        //        console.commandToClient(client, console.addTaggedString("setNumericalHealthHUD"), new[] { ((int)curhealth).AsString() });
        //    }

        [Torque_Decorations.TorqueCallBack("", "Player", "setDamageDirection", "(%player, %sourceObject, %damagePos)", 3, 2400, false)]
        public void PlayerSetDamageDirection(coPlayer player, coPlayer sourceObject, TransformF damagePos)
            {
            if (sourceObject.isObject())
                damagePos = console.isField(sourceObject, "initialPosition") ? new TransformF(sourceObject["initialPosition"]) : sourceObject.getTransform();


            TransformF dp = damagePos;
            Point3F wbc = player.getWorldBoxCenter();

            TransformF damagevec = dp - new TransformF(wbc);
            damagevec = damagevec.normalizeSafe();

            coGameConnection client = player["client"];
            if (!client.isObject())
                return;


            coCamera cameraobject = client.getCameraObject();

            TransformF inverseTransform = cameraobject.getInverseTransform();
            damagevec = math.MatrixMulVector(inverseTransform, damagevec.MPosition);

            float[] components = new float[6];
            string[] directions = new string[6];
            directions[0] = "Left";
            directions[1] = "Right";
            directions[2] = "Bottom";
            directions[3] = "Front";
            directions[4] = "Bottom";
            directions[5] = "Top";

            components[0] = -damagevec.MPosition.x;
            components[1] = damagevec.MPosition.x;
            components[2] = -damagevec.MPosition.y;
            components[3] = damagevec.MPosition.y;
            components[4] = -damagevec.MPosition.z;
            components[5] = damagevec.MPosition.z;
            string damagedirection = string.Empty;
            float max = 0;
            for (int i = 0; i < 6; i++)
                {
                if (components[i] <= max)
                    continue;
                damagedirection = directions[i];
                max = components[i];
                }

            if (console.isObject(client))
                console.commandToClient(client, console.addTaggedString("setDamageDirection"), new[] { damagedirection });
            }

        [Torque_Decorations.TorqueCallBack("", "Player", "use", "(%player, %data,nameSpaceDepth)", 3, 2400, false)]
        public void PlayerUse(coPlayer player, string data, int nameSpaceDepth)
            {
            if (PlayerIsPilot(player))
                return;
            int nsd = (nameSpaceDepth + 1);
            console.ParentExecute(player, "use", nsd - 1, new string[] { player, data, nsd.AsString() });
            }
        }
    }