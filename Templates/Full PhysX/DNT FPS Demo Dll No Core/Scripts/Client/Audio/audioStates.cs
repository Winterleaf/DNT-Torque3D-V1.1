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

namespace DNT_FPS_Demo_Game_Dll.Scripts.Client
    {
    public partial class Main : TorqueScriptTemplate
        {
        /// Return the first active SFXState in the given SimSet/SimGroup.
        [Torque_Decorations.TorqueCallBack("", "", "sfxGetActiveStateInGroup", "", 1, 28000, false)]
        public coGuiControl sfxGetActiveStateInGroup(coSimSet group)
            {
            for (uint i = 0; i < group.getCount(); i++)
                {
                coGuiControl obj = group.getObject(i);
                if (obj.isMemberOfClass("SFXState"))
                    continue;

                if (obj.isActive())
                    return obj;
                }
            return "";
            }

        [Torque_Decorations.TorqueCallBack("", "", "initialize_AudioStates", "", 0, 28000, true)]
        public void initialize_AudioStates()
            {
            coSFXState AudioStateNone = new TorqueSingleton("SFXState", "AudioStateNone").Create();
            AudioStateNone.activate();
            }

        [Torque_Decorations.TorqueCallBack("", "SFXState", "onActivate", "this", 1, 28000, false)]
        public void SFXState_onActivate(coSFXState thisobj)
            {
            coSFXState AudioStateNone = "AudioStateNone";
            if (thisobj != AudioStateNone)
                AudioStateNone.disable();
            }

        [Torque_Decorations.TorqueCallBack("", "SFXState", "onDeactivate", "this", 1, 28000, false)]
        public void onDeactivate(coSFXState thisobj)
            {
            coSFXState AudioStateNone = "AudioStateNone";
            if (thisobj != AudioStateNone)
                AudioStateNone.enable();
            }

        //-----------------------------------------------------------------------------
        // AudioStateExclusive class.
        //
        // Automatically deactivates sibling SFXStates in its parent SimGroup
        // when activated.

        [Torque_Decorations.TorqueCallBack("", "AudioStateExclusive", "onActivate", "this", 1, 28000, false)]
        public void AudioStateExclusiveonActivate(coSimObject thisobj)
            {
            console.ParentExecute(thisobj.ID, "onActivate", 1, new[] {thisobj.ID});
            coSimSet group = thisobj["parentGroup"];
            for (uint i = 0; i < group.getCount(); i++)
                {
                coSFXState obj = group.getObject(i);
                if (obj != thisobj && obj.isMemberOfClass("SFXState") && obj.isActive())
                    obj.deactivate();
                }
            }

        [Torque_Decorations.TorqueCallBack("", "", "initialize_AudioStates1", "", 0, 28000, true)]
        public void initialize_AudioState1s()
            {
            TorqueSingleton ts = new TorqueSingleton("SimGroup", "AudioLocation");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioLocationOutside");
            ts.Props.Add("parentGroup", "AudioLocation");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioLocationUnderwater");
            ts.Props.Add("parentGroup", "AudioLocation");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioLocationInside");
            ts.Props.Add("parentGroup", "AudioLocation");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();
            }

        [Torque_Decorations.TorqueCallBack("", "", "sfxGetLocation", "this", 0, 28000, false)]
        public string sfxGetLocation()
            {
            return console.Call("sfxGetActiveStateInGroup", new[] {"AudioLocation"});
            }

        [Torque_Decorations.TorqueCallBack("", "", "initialize_AudioStates2", "", 0, 28000, true)]
        public void initialize_AudioState2s()
            {
            TorqueSingleton ts = new TorqueSingleton("SimGroup", "AudioMood");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioMoodNeutral");
            ts.Props.Add("parentGroup", "AudioMood");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioMoodAggressive");
            ts.Props.Add("parentGroup", "AudioMood");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();


            ts = new TorqueSingleton("SFXState", "AudioMoodTense");
            ts.Props.Add("parentGroup", "AudioMood");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioMoodVictory");
            ts.Props.Add("parentGroup", "AudioMood");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();

            ts = new TorqueSingleton("SFXState", "AudioMoodCalm");
            ts.Props.Add("parentGroup", "AudioMood");
            ts.PropsAddString("className", "AudioStateExclusive");
            ts.Create();
            }

        [Torque_Decorations.TorqueCallBack("", "", "sfxGetMood", "this", 0, 28000, false)]
        public string sfxGetMood()
            {
            return sfxGetActiveStateInGroup("AudioMood");
            }
        }
    }