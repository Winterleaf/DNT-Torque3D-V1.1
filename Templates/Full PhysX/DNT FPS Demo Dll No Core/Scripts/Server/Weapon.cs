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
using WinterLeaf.Containers;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Server
    {
    public partial class Main : TorqueScriptTemplate
        {
        public const int WeaponSlot = 0;

        [Torque_Decorations.TorqueCallBack("", "", "WeaponInitialize", "", 0, 1900, true)]
        public void WeaponInitialize()
            {
            iGlobal["$WeaponSlot"] = 0;
            }

        [Torque_Decorations.TorqueCallBack("", "Weapon", "onUse", "(%data, %obj)", 2, 1900, false)]
        public void WeaponOnUser(coScriptObject data, coPlayer obj)
            {
            if (obj.getMountedImage(WeaponSlot) == data["image"].AsInt())
                return;

            AudioServerPlay3D("WeaponUseSound", obj.getTransform());


            obj.mountImage(data["image"], WeaponSlot, true, "");

            if (obj["client"].AsBool())
                {
                if (data["description"] != "")

                    MessageClient(obj["client"], "MsgWeaponUsed", "\\c3%1 \\c5 selected.", data["description"]);
                else
                    MessageClient(obj["client"], "MsgWeaponUsed", console.addTaggedString(@"\c0Weapon selected"));
                }

            if (obj.isInNamespaceHierarchy("Player"))
                return;

            obj.allowAllPoses();
            coSimObject image = data["image"];

            if (image["jumpingDisallowed"].AsBool())
                obj.allowJumping(false);

            if (image["jetJumpingDisallowed"].AsBool())
                obj.allowJetJumping(false);

            if (image["sprintDisallowed"].AsBool())
                obj.allowSprinting(false);

            if (image["crouchDisallowed"].AsBool())
                obj.allowCrouching(false);

            if (image["proneDisallowed"].AsBool())
                obj.allowProne(false);

            if (image["swimmingDisallowed"].AsBool())
                obj.allowSwimming(false);
            }

        [Torque_Decorations.TorqueCallBack("", "Weapon", "onPickup", "(%this, %obj, %shape, %amount)", 5, 1900, false)]
        public void WeaponOnPickup(coScriptObject thisobj, string obj, coShapeBase shape, int amount, int nameSpaceDepth)
            {
            int nsd = (nameSpaceDepth + 1);
            if (!console.ParentExecute(thisobj, "onPickup", nsd, new string[] { thisobj, obj, shape, amount.AsString() }).AsBool())
                return;


            AudioServerPlay3D("WeaponPickupSound", shape.getTransform());

            if (shape.getClassName() == "Player" && shape.getMountedImage(WeaponSlot) == 0)
                shape.call("use", thisobj);
            }

        [Torque_Decorations.TorqueCallBack("", "Weapon", "onInventory", "(%this, %obj, %amount)", 3, 1900, false)]
        public void WeaponOnInventory(coScriptObject thisobj, coShapeBase obj, int amount)
            {
            if (amount != 0 || !obj.isMethod("getMountSlot"))
                return;
            int slot = obj.getMountSlot(thisobj["image"]);
            obj.unmountImage(slot);
            }

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onMount", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageOnMount(coScriptObject thisobj, coPlayer player, int slot)
            {
            coGameConnection client = player["client"];

            string ammoName = "";
            ammoName = ((coItemData)thisobj["ammo"]).getName();


            int currentammo = 0;
            int ammountinClips = 0;
            if (thisobj.isField("clip"))
                {
                if (ShapeBaseShapeBaseGetInventory(player, thisobj["ammo"]).AsBool())
                    {
                    player.setImageAmmo(slot, true);
                    currentammo = ShapeBaseShapeBaseGetInventory(player, thisobj["ammo"]);
                    }
                else if (ShapeBaseShapeBaseGetInventory(player, thisobj["clip"]) > 0)
                    {
                    ShapeBaseShapeBaseSetInventory(player, thisobj["ammo"], thisobj["ammo.maxInventory"].AsInt());
                    player.setImageAmmo(slot, true);

                    currentammo = thisobj["ammo.maxInventory"].AsInt();
                    ammountinClips += player["remaining" + ammoName].AsInt();
                    }
                else
                    {
                    ammountinClips += player["remaining" + ammoName].AsInt();
                    }

                ammountinClips = ShapeBaseShapeBaseGetInventory(player, thisobj["clip"]);
                ammountinClips *= thisobj["ammo.maxInventory"].AsInt();

                if ((player["client"] != "") && !player["isAiControlled"].AsBool())
                    {
                    GameConnectionRefreshWeaponHud(client, currentammo, thisobj["item.previewImage"], thisobj["item.reticle"], thisobj["item.zoomReticle"], ammountinClips);
                    }
                }
            else if (thisobj["ammo"] != "")
                {
                if (ShapeBaseShapeBaseGetInventory(player, thisobj["ammo"]).AsBool())
                    {
                    player.setImageAmmo(slot, true);
                    currentammo = ShapeBaseShapeBaseGetInventory(player, thisobj["ammo"]);
                    }
                else
                    currentammo = 0;


                if (player["client"] != "" && !player["isAiControlled"].AsBool())
                    GameConnectionRefreshWeaponHud(client, 1, thisobj["item.previewImage"], thisobj["item.reticle"], thisobj["item.zoomReticle"], currentammo);
                }
            }

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onUnmount", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageOnUnmount(coScriptObject thisobj, coPlayer player, int slot)
            {
            coGameConnection client = player["client"];
            if (client != "" && player["isAiControlled"].AsBool())
                GameConnectionRefreshWeaponHud(client, 0, "", "", "", 0);
            }

        // ----------------------------------------------------------------------------
        // A "generic" weaponimage onFire handler for most weapons.  Can be overridden
        // with an appropriate namespace method for any weapon that requires a custom
        // firing solution.

        // projectileSpread is a dynamic property declared in the weaponImage datablock
        // for those weapons in which bullet skew is desired.  Must be greater than 0,
        // otherwise the projectile goes straight ahead as normal.  lower values give
        // greater accuracy, higher values increase the spread pattern.
        // ----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onFire", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageOnFire(coScriptObject thisobj, coPlayer obj, int slot)
            {
            if (!((coItem)thisobj["projectile"]).isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.

            if (!thisobj["infiniteAmmo"].AsBool())
                ShapeBaseShapeBaseDecInventory(obj, thisobj["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = thisobj["projectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (thisobj["projectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.MPosition.x = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["projectileSpread"].AsFloat());
                    matrix.MPosition.y = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["projectileSpread"].AsFloat());
                    matrix.MPosition.z = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["projectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(thisobj["projectile.muzzleVelocity"].AsFloat());


                objectVelocity = objectVelocity.vectorScale(thisobj["projectile.velInheritFactor"].AsFloat());

                Point3F muzzleVelocity = muzzleVector.MPosition + objectVelocity;

                Torque_Class_Helper tch = new Torque_Class_Helper(thisobj["projectileType"]);
                tch.Props.Add("dataBlock", thisobj["projectile"]);
                tch.Props.Add("initialVelocity", '"' + muzzleVelocity.AsString() + '"');
                tch.Props.Add("initialPosition", '"' + obj.getMuzzlePoint(slot).AsString() + '"');
                tch.Props.Add("sourceObject", obj);
                tch.Props.Add("sourceSlot", slot.AsString());
                tch.Props.Add("client", obj["client"]);
                tch.Props.Add("sourceClass", obj.getClassName());

                coProjectile projectile = tch.Create();

                ((coSimSet)"MissionCleanup").pushToBack(projectile);
                }
            }


        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onAltFire", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageonAltFire(coScriptObject thisobj, coPlayer obj, int slot)
            {
            if (!thisobj["projectile"].isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.

            if (!thisobj["infiniteAmmo"].AsBool())
                ShapeBaseShapeBaseDecInventory(obj, thisobj["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = thisobj["altProjectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (thisobj["altProjectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.MPosition.x = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["altProjectileSpread"].AsFloat());
                    matrix.MPosition.y = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["altProjectileSpread"].AsFloat());
                    matrix.MPosition.z = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["altProjectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(thisobj["altProjectile.muzzleVelocity"].AsFloat());
                objectVelocity = objectVelocity.vectorScale(thisobj["altProjectile.velInheritFactor"].AsFloat());
                Point3F muzzleVelocity = muzzleVector.MPosition + objectVelocity;

                Torque_Class_Helper tch = new Torque_Class_Helper(((coItem)thisobj["altProjectileType"]).getName(), "");
                tch.Props.Add("dataBlock", thisobj["altProjectile"]);
                tch.Props.Add("initialVelocity", '"' + muzzleVelocity.ToString() + '"');
                tch.Props.Add("initialPosition", '"' + obj.getMuzzlePoint(slot).ToString() + '"');
                tch.Props.Add("sourceObject", obj);
                tch.Props.Add("sourceSlot", slot.AsString());
                tch.Props.Add("client", obj["client"]);
                tch.Props.Add("sourceClass", obj.getClassName());

                coItem projectile = tch.Create();
                ((coSimSet)"MissionCleanup").pushToBack(projectile);
                }
            }

        // ----------------------------------------------------------------------------
        // A "generic" weaponimage onWetFire handler for most weapons.  Can be
        // overridden with an appropriate namespace method for any weapon that requires
        // a custom firing solution.
        // ----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onWetFire", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageonWetFire(coScriptObject thisobj, coPlayer obj, int slot)
            {
            if (!thisobj["projectile"].isObject())
                {
                console.error("WeaponImage::onFire() - Invalid projectile datablock");
                return;
                }
            // Decrement inventory ammo. The image's ammo state is updated
            // automatically by the ammo inventory hooks.
            if (!thisobj["infiniteAmmo"].AsBool())
                ShapeBaseShapeBaseDecInventory(obj, thisobj["ammo"], 1);

            // Get the player's velocity, we'll then add it to that of the projectile
            int numProjectiles = thisobj["projectileNum"].AsInt();
            if (numProjectiles == 0)
                numProjectiles = 1;
            TransformF muzzleVector = new TransformF();

            for (int i = 0; i < numProjectiles; i++)
                {
                if (thisobj["wetProjectileSpread"].AsBool())
                    {
                    // We'll need to "skew" this projectile a little bit.  We start by
                    // getting the straight ahead aiming point of the gun
                    Point3F vec = obj.getMuzzleVector(slot);
                    // Then we'll create a spread matrix by randomly generating x, y, and z
                    // points in a circle
                    Random r = new Random();
                    TransformF matrix = new TransformF();
                    matrix.MPosition.x = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["wetProjectileSpread"].AsFloat());
                    matrix.MPosition.y = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["wetProjectileSpread"].AsFloat());
                    matrix.MPosition.z = (float)((r.NextDouble() - .5) * 2 * Math.PI * thisobj["wetProjectileSpread"].AsFloat());
                    TransformF mat = math.MatrixCreateFromEuler(matrix);

                    muzzleVector = math.MatrixMulVector(mat, vec);
                    }
                else
                    {
                    muzzleVector = new TransformF(obj.getMuzzleVector(slot));
                    }
                Point3F objectVelocity = obj.getVelocity();

                muzzleVector = muzzleVector.vectorScale(thisobj["wetProjectile.muzzleVelocity"].AsFloat());

                objectVelocity = objectVelocity.vectorScale(thisobj["wetProjectile.velInheritFactor"].AsFloat());
                Point3F muzzleVelocity = muzzleVector.MPosition + objectVelocity;

                Torque_Class_Helper tch = new Torque_Class_Helper(thisobj["projectileType"]);


                tch.Props.Add("dataBlock", thisobj["wetProjectile"]);
                tch.Props.Add("initialVelocity", '"' + muzzleVelocity.AsString() + '"');
                tch.Props.Add("initialPosition", '"' + obj.getMuzzlePoint(slot).AsString() + '"');
                tch.Props.Add("sourceObject", obj);
                tch.Props.Add("sourceSlot", slot.AsString());
                tch.Props.Add("client", obj["client"]);
                tch.Props.Add("sourceClass", obj.getClassName());

                coItem projectile = tch.Create();
                ((coSimSet)"MissionCleanup").pushToBack(projectile);
                }
            }

        //-----------------------------------------------------------------------------
        // Clip Management
        //-----------------------------------------------------------------------------

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "onClipEmpty", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageOnClipEmpty(coScriptObject thisobj, coPlayer obj, int slot)
            {
            thisobj.schedule("0", "reloadAmmoClip", obj, slot.AsString());
            }

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "reloadAmmoClip", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageReloadAmmoClip(coItemData thisobj, coShapeBase obj, int slot)
            {
            string ammoname = ((coItemData)thisobj["ammo"]).getName();

            if (thisobj != obj.getMountedImage(slot))
                return;

            if (!thisobj.isField("clip"))
                return;
            if (ShapeBaseShapeBaseGetInventory(obj, thisobj["clip"]) > 0)
                {
                ShapeBaseShapeBaseDecInventory(obj, thisobj["clip"], 1);

                ShapeBaseShapeBaseSetInventory(obj, thisobj["ammo"], thisobj["ammo.maxInventory"].AsInt());

                obj.setImageAmmo(slot, true);
                }
            else
                {
                int amountInPocket = obj["remaining" + ((coItem)thisobj["ammo"]).getName()].AsInt();
                if (amountInPocket > 0)
                    {
                    obj["remaining" + ((coItem)thisobj["ammo"]).getName()] = "0";

                    ShapeBaseShapeBaseSetInventory(obj, thisobj["ammo"], amountInPocket);
                    obj.setImageAmmo(slot, true);
                    }
                }
            }

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "clearAmmoClip", "(%this, %obj, %slot)", 3, 1900, false)]
        public void WeaponImageClearAmmoClip(coItemData thisobj, coPlayer obj, int slot)
            {
            //echo("WeaponImage::clearAmmoClip: " SPC %this SPC %obj SPC %slot);

            // if we're not empty put the remaining bullets from the current clip
            // in to the player's "pocket".

            if (!thisobj["clip"].isObject())
                return;
            // Commenting out this line will use a "hard clip" system, where
            // A player will lose any ammo currently in the gun when reloading.
            int pocketAmount = WeaponImageStashSpareAmmo(thisobj, obj);
            if (ShapeBaseShapeBaseGetInventory(obj, thisobj["clip"]) > 0 || pocketAmount != 0)
                obj.setImageAmmo(slot, false);
            }

        [Torque_Decorations.TorqueCallBack("", "WeaponImage", "stashSpareAmmo", "( %this, %player )", 2, 1900, false)]
        public int WeaponImageStashSpareAmmo(coItemData thisobj, coPlayer player)
            {
            // If the amount in our pocket plus what we are about to add from the clip
            // Is over a clip, add a clip to inventory and keep the remainder
            // on the player
            coItemData ammo = thisobj["ammo"];
            if (ShapeBaseShapeBaseGetInventory(player, ammo) < thisobj["ammo.maxInventory"].AsInt())
                {
                string nameOfAmmoField = "remaining" + ammo.getName();


                int amountInPocket = player[nameOfAmmoField].AsInt();

                int amountIngun = ShapeBaseShapeBaseGetInventory(player, thisobj["ammo"]);
                int combinedammo = amountInPocket + amountIngun;

                if (combinedammo >= thisobj["ammo.maxInventory"].AsInt())
                    {
                    player[nameOfAmmoField] = (combinedammo - thisobj["ammo.maxInventory"].AsInt()).AsString();

                    ShapeBaseShapeBaseIncInventory(player, thisobj["clip"], 1);
                    }
                else if (ShapeBaseShapeBaseGetInventory(player, thisobj["clip"]) > 0)
                    player[nameOfAmmoField] = combinedammo.AsString();

                return player[nameOfAmmoField].AsInt();
                }

            return 0;
            }

        [Torque_Decorations.TorqueCallBack("", "AmmoClip", "onPickup", "(%this, %obj, %shape, %amount, %nameSpaceDepth)", 5, 1900, false)]
        public void AmmoClipOnPickup(coItem thisobj, string obj, coPlayer shape, string amount, int nameSpaceDepth)
            {
            int nsd = nameSpaceDepth + 1;

            if (!console.ParentExecute(thisobj, "onPickup", nsd, new string[] { thisobj, obj, shape, amount }).AsBool())
                return;

            AudioServerPlay3D("WeaponPickupSound", shape.getTransform());

            coItemData image = shape.getMountedImage(WeaponSlot);

            if (image == 0)
                return;

            if (!console.isField(image, "clip") || console.Call(string.Format("{0}.clip", image), "getID") != console.Call(thisobj, "getID"))
                return;

            bool outOfAmmo = !shape.getImageAmmo(WeaponSlot);

            int amountInClips = 0;

            int currentAmmo = ShapeBaseShapeBaseGetInventory(shape, image["ammo"]);

            if (console.isObject(image["clip"]))
                amountInClips = ShapeBaseShapeBaseGetInventory(shape, image["clip"]);

            int t = console.GetVarInt(string.Format("{0}.ammo.maxInventory", image));

            amountInClips *= t;

            int amountloadedingun = console.GetVarInt(string.Format("{0}.remaining{1}", obj, console.GetVarString(string.Format("{0}.ammo", this))));

            amountInClips += amountloadedingun;



            GameConnectionSetAmmoAmountHud(shape["client"], currentAmmo, amountInClips);

            if (outOfAmmo)
                console.Call(image, "onClipEmpty", new string[] { shape, WeaponSlot.AsString() });
            }

        [Torque_Decorations.TorqueCallBack("", "Ammo", "onPickup", "(%this, %obj, %shape, %amount, %nameSpaceDepth)", 5, 1900, false)]
        public void AmmoOnPickup(string thisobj, string obj, coSceneObject shape, string amount, int nameSpaceDepth)
            {
            int nsd = nameSpaceDepth + 1;
            if (console.ParentExecute(thisobj, "onPickup", nsd, new string[] { thisobj, obj, shape, amount }).AsBool())
                AudioServerPlay3D("AmmoPickupSound", shape.getTransform());
            }

        [Torque_Decorations.TorqueCallBack("", "Ammo", "onInventory", "(%this, %obj, %amount)", 3, 1900, false)]
        public void AmmoOnInventory(coItemData thisobj, coPlayer player, int amount)
            {
            coGameConnection client = player["client"];
            for (int i = 0; i < 8; i++)
                {
                coItemData image = player.getMountedImage(i);
                if (image <= 0)
                    continue;

                if (!image["ammo"].isObject())
                    continue;
                if (console.Call(image["ammo"], "getID") != console.Call(thisobj, "getID"))
                    continue;


                player.setImageAmmo(i, amount != 0);

                int currentammo = ShapeBaseShapeBaseGetInventory(player, thisobj);

                if (player.getClassName() != "Player")
                    continue;

                int amountInClips;

                if (thisobj["clip"].isObject())
                    {
                    amountInClips = ShapeBaseShapeBaseGetInventory(player, thisobj["clip"]);

                    amountInClips *= thisobj["maxInventory"].AsInt();

                    amountInClips += player["remaining" + thisobj.getName()].AsInt();
                    }
                else
                    {
                    amountInClips = currentammo;
                    currentammo = 1;
                    }
                if (player["client"] != "" && !player["isAiControlled"].AsBool())
                    {
                    GameConnectionSetAmmoAmountHud(client, currentammo, amountInClips);
                    }
                }
            }


        [Torque_Decorations.TorqueCallBack("", "ShapeBase", "clearWeaponCycle", "(%this", 1, 1900, false)]
        public void ShapeBaseClearWeaponCycle(coPlayer thisobj)
            {
            thisobj["totalCycledWeapons"] = "0";
            }

        [Torque_Decorations.TorqueCallBack("", "ShapeBase", "addToWeaponCycle", "(%this,%weapon)", 2, 1900, false)]
        public void ShapeBaseAddToWeaponCycle(coPlayer player, string weapon)
            {
            player["cycleWeapon[" + player["totalCycledWeapons"].AsString() + "]"] = weapon;
            player["totalCycledWeapons"] = (player["totalCycledWeapons"].AsInt() + 1).AsString();
            }

        [Torque_Decorations.TorqueCallBack("", "ShapeBase", "cycleWeapon", "(%this, %direction)", 2, 1900, false)]
        public void ShapeBaseCycleWeapon(coShapeBase thisobj, string direction)
            {
            //I sure seem to retrieve "thisobj.totalCycledWeapons" alot,
            //So to save so work, I'm just gonna grab it here.
            int totalCycledWeapons = thisobj["totalCycledWeapons"].AsInt();


            // Can't cycle what we don't have
            if (totalCycledWeapons == 0)
                return;
            // Find out the index of the current weapon, if any (not all
            // available weapons may be part of the cycle)
            int currentIndex = -1;


            coItemData mountedimage = thisobj.getMountedImage(WeaponSlot);

            if (mountedimage.isObject())
                {
                string curWeapon = mountedimage["item"];
                for (int i = 0; i < totalCycledWeapons; i++)
                    {
                    if (thisobj["cycleWeapon[" + i + "]"] != curWeapon)
                        continue;
                    currentIndex = i;
                    break;
                    }
                }



            int nextIndex = 0;
            int dir = 1;
            if (currentIndex != -1)
                {
                if (direction == "prev")
                    {
                    dir = -1;
                    nextIndex = currentIndex - 1;
                    if (nextIndex < 0)
                        {
                        nextIndex = totalCycledWeapons - 1;
                        }
                    }
                else
                    {
                    nextIndex = currentIndex + 1;
                    if (nextIndex >= totalCycledWeapons)
                        {
                        nextIndex = 0;
                        }
                    }
                }
            bool found = false;
            coItemData weapon = null;
            for (int i = 0; i < totalCycledWeapons; i++)
                {
                weapon = thisobj["cycleWeapon[" + i + "]"];
                if ((weapon != 0) && (ShapeBaseShapeBaseHasInventory(thisobj, weapon)))
                    {
                    found = true;
                    break;
                    }
                nextIndex = nextIndex + dir;
                if (nextIndex < 0)
                    nextIndex = totalCycledWeapons - 1;
                else if (nextIndex >= totalCycledWeapons)
                    nextIndex = 0;
                }
            if (!found)
                return;
            weapon = thisobj["cycleWeapon[" + nextIndex + "]"];
            ShapeBaseShapeBaseUse(thisobj, weapon);
            }
        }
    }