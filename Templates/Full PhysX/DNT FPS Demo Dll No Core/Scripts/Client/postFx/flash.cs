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
// Last updated: 04/10/2013
// 

#region

using WinterLeaf.Classes;
using WinterLeaf.tsObjects;

#endregion

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        [Torque_Decorations.TorqueCallBack("", "", "flash_Init", "", 0, 94000, true)]
        public void flash_Init()
            {
            TorqueSingleton ts = new TorqueSingleton("ShaderData", "PFX_FlashShader");
            ts.PropsAddString("DXVertexShaderFile", "shaders/common/postFx/postFxV.hlsl");
            ts.PropsAddString("DXPixelShaderFile", "shaders/common/postFx/flashP.hlsl");
            ts.PropsAddString("defines", "WHITE_COLOR=float4(1.0,1.0,1.0,0.0);MUL_COLOR=float4(1.0,0.25,0.25,0.0)");
            ts.Props.Add("pixVersion", "2.0");
            ts.Create();

            ts = new TorqueSingleton("PostEffect", "FlashFx");
            ts.Props.Add("isEnabled", "false");
            ts.Props.Add("allowReflectPass", "false");

            ts.PropsAddString("renderTime", "PFXAfterDiffuse");

            ts.Props.Add("shader", "PFX_FlashShader");
            ts.PropsAddString("texture[0]", "$backBuffer");
            ts.Props.Add("renderPriority", "10");
            ts.Props.Add("stateBlock", "PFX_DefaultStateBlock");
            ts.Create();
            }

        //private bool flashskip = true;

        [Torque_Decorations.TorqueCallBack("", "FlashFx", "setShaderConsts", "", 1, 94100, false)]
        public void FlashFxsetShaderConsts(coPostEffect thisobj)
            {
            coGameConnection serverConnection = "ServerConnection";

            if (console.isObject(thisobj))
                {
                thisobj.setShaderConst("$damageFlash", serverConnection.getDamageFlash().AsString());
                thisobj.setShaderConst("$whiteOut", serverConnection.getWhiteOut().AsString());
                }
            else
                {
                thisobj.setShaderConst("$damageFlash", "0");
                thisobj.setShaderConst("$whiteOut", "0");
                }
            }
        }
    }