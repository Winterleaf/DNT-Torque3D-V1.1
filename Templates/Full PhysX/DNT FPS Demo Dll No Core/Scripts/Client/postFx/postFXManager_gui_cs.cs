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
        [Torque_Decorations.TorqueCallBack("", "", "postFXManager_gui_cs_cs_Init", "", 0, 103000, true)]
        public void postFXManager_gui_cs_cs_Init()
            {
            bGlobal["$PostFXManager::vebose"] = true;
            }

        [Torque_Decorations.TorqueCallBack("", "", "postVerbose", "%string", 1, 103010, false)]
        public void postVerbose(string sstring)
            {
            if (bGlobal["$PostFXManager::vebose"])
                console.print(sstring);
            }

        [Torque_Decorations.TorqueCallBack("", "PostFXManager", "onDialogPush", "%this", 1, 103020, false)]
        public void PostFXManageronDialogPush(string thisobj)
            {
            //Apply the settings to the controls
            postVerbose("% - PostFX Manager - Loading GUI.");
            PostFXManagersettingsRefreshAll(thisobj);
            }

        // :: Controls for the overall postFX manager dialog
        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnable", "onAction", "%this", 1, 103030, false)]
        public void ppOptionsEnableonAction(string thisobj)
            {
            coGuiCheckBoxCtrl ppOptionsEnable = "ppOptionsEnable";
            PostFXManagersettingsSetEnabled(thisobj, ppOptionsEnable.getValue().AsBool() ? true.AsString() : false.AsString());
            }

        [Torque_Decorations.TorqueCallBack("", "PostFXManager", "getEnableResultFromControl", "%this, %control", 2, 103040, false)]
        public bool PostFXManagergetEnableResultFromControl(string thisobj, coGuiControl control)
            {
            return control.getValue().AsBool();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnableSSAO", "onAction", "%this", 1, 103050, false)]
        public void ppOptionsEnableSSAOonAction(coGuiControl thisobj)
            {
            PostFXManagersettingsEffectSetEnabled("PostFXManager", "SSAO", PostFXManagergetEnableResultFromControl("PostFXManager", thisobj));
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnableHDR", "onAction", "%this", 1, 103060, false)]
        public void ppOptionsEnableHDRonAction(coGuiControl thisobj)
            {
            PostFXManagersettingsEffectSetEnabled("PostFXManager", "HDR", PostFXManagergetEnableResultFromControl("PostFXManager", thisobj));
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnableLightRays", "onAction", "%this", 1, 103070, false)]
        public void ppOptionsEnableLightRaysonAction(coGuiControl thisobj)
            {
            PostFXManagersettingsEffectSetEnabled("PostFXManager", "LightRays", PostFXManagergetEnableResultFromControl("PostFXManager", thisobj));
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnableDOF", "onAction", "%this", 1, 103080, false)]
        public void ppOptionsEnableDOFsonAction(coGuiControl thisobj)
            {
            PostFXManagersettingsEffectSetEnabled("PostFXManager", "DOF", PostFXManagergetEnableResultFromControl("PostFXManager", thisobj));
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSavePreset", "onClick", "%this", 1, 103090, false)]
        public void ppOptionsSavePresetonClick(string thisobj)
            {
            //Stores the current settings into a preset file for loading and use later on 
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsLoadPreset", "onClick", "%this", 1, 103100, false)]
        public void ppOptionsLoadPresetonClick(string thisobj)
            {
            //Loads and applies the settings from a postfxpreset file
            }

        //Other controls, Quality dropdown
        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOQuality", "onSelect", "%this, %id, %text", 3, 103110, false)]
        public void ppOptionsSSAOQualityonSelect(string thisobj, string id, string text)
            {
            if (id.AsInt() > -1 && id.AsInt() < 3)
                sGlobal["$SSAOPostFx::quality"] = id;
            }

        //SSAO Slider controls
        //General Tab
        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOOverallStrength", "onMouseDragged", "%this", 1, 103120, false)]
        public void ppOptionsSSAOOverallStrengthonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::overallStrength"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOBlurDepth", "onMouseDragged", "%this", 1, 103130, false)]
        public void ppOptionsSSAOBlurDepthonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::blurDepthTol"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOBlurNormal", "onMouseDragged", "%this", 1, 103140, false)]
        public void ppOptionsSSAOBlurNormalonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::blurNormalTol"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAONearRadius", "onMouseDragged", "%this", 1, 103150, false)]
        public void ppOptionsSSAONearRadiusonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::sRadius"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAONearStrength", "onMouseDragged", "%this", 1, 103160, false)]
        public void ppOptionsSSAONearStrengthonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::sStrength"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAONearDepthMin", "onMouseDragged", "%this", 1, 103170, false)]
        public void ppOptionsSSAONearDepthMinonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::sDepthMin"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAONearToleranceNormal", "onMouseDragged", "%this", 1, 103180, false)]
        public void ppOptionsSSAONearToleranceNormalonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::sNormalTol"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAONearTolerancePower", "onMouseDragged", "%this", 1, 103190, false)]
        public void ppOptionsSSAONearTolerancePoweronMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::sNormalPow"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarRadius", "onMouseDragged", "%this", 1, 103200, false)]
        public void ppOptionsSSAOFarRadiusonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lRadius"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarStrength", "onMouseDragged", "%this", 1, 103210, false)]
        public void ppOptionsSSAOFarStrengthonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lStrength"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarDepthMin", "onMouseDragged", "%this", 1, 103220, false)]
        public void ppOptionsSSAOFarDepthMinonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lDepthMin"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarDepthMax", "onMouseDragged", "%this", 1, 103230, false)]
        public void ppOptionsSSAOFarDepthMaxonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lDepthMax"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarToleranceNormal", "onMouseDragged", "%this", 1, 103240, false)]
        public void ppOptionsSSAOFarToleranceNormalonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lNormalTol"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsSSAOFarTolerancePower", "onMouseDragged", "%this", 1, 103250, false)]
        public void ppOptionsSSAOFarTolerancePoweronMouseDragged(coSimObject thisobj)
            {
            sGlobal["$SSAOPostFx::lNormalPow"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRToneMappingAmount", "onMouseDragged", "%this", 1, 103260, false)]
        public void ppOptionsHDRToneMappingAmountonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::enableToneMapping"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRKeyValue", "onMouseDragged", "%this", 1, 103270, false)]
        public void ppOptionsHDRKeyValueonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::keyValue"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRMinLuminance", "onMouseDragged", "%this", 1, 103280, false)]
        public void ppOptionsHDRMinLuminanceonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::minLuminace"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRWhiteCutoff", "onMouseDragged", "%this", 1, 103290, false)]
        public void ppOptionsHDRWhiteCutoffonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::whiteCutoff"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBrightnessAdaptRate", "onMouseDragged", "%this", 1, 103300, false)]
        public void ppOptionsHDRBrightnessAdaptRateonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::adaptRate"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBloomBlurBrightPassThreshold", "onMouseDragged", "%this", 1, 103310, false)]
        public void ppOptionsHDRBloomBlurBrightPassThresholdonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::brightPassThreshold"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBloomBlurMultiplier", "onMouseDragged", "%this", 1, 103320, false)]
        public void ppOptionsHDRBloomBlurMultiplieronMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::gaussMultiplier"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBloomBlurMean", "onMouseDragged", "%this", 1, 103330, false)]
        public void ppOptionsHDRBloomBlurMeanonMouseDragged(coSimObject thisobj)
            {
            sGlobal["$HDRPostFX::gaussMean"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBloomBlurStdDev", "onMouseDragged", "%this", 1, 103340, false)]
        public void ppOptionsHDRBloomBlurStdDevonMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$HDRPostFX::gaussStdDev"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRBloom", "onAction", "%this", 1, 103350, false)]
        public void ppOptionsHDRBloomonAction(coGuiCheckBoxCtrl thisobj)
            {
            sGlobal["$HDRPostFX::enableBloom"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }


        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDRToneMapping", "onAction", "%this", 1, 103360, false)]
        public void ppOptionsHDRToneMappingonAction(coGuiCheckBoxCtrl thisobj)
            {
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDREffectsBlueShift", "onAction", "%this", 1, 103370, false)]
        public void ppOptionsHDREffectsBlueShiftonAction(coGuiCheckBoxCtrl thisobj)
            {
            sGlobal["$HDRPostFX::enableBlueShift"] = thisobj.getValue();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDREffectsBlueShiftColorBlend", "onAction", "%this", 1, 103380, false)]
        public void ppOptionsHDREffectsBlueShiftColorBlendonAction(coGuiColorPickerCtrl thisobj)
            {
            sGlobal["$HDRPostFX::blueShiftColor"] = thisobj["PickColor"];
            thisobj["toolTip"] = "Color Value : " + thisobj["PickColor"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsHDREffectsBlueShiftColorBaseColor", "onAction", "%this", 1, 103390, false)]
        public void ppOptionsHDREffectsBlueShiftColorBaseColoronAction(coGuiColorPickerCtrl thisobj)
            {
            ((coGuiColorPickerCtrl)"ppOptionsHDREffectsBlueShiftColorBlend")["baseColor"] = thisobj["PickColor"];
            thisobj["toolTip"] = "Color Value : " + thisobj["PickColor"];
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsLightRaysBrightScalar", "onMouseDragged", "%this", 1, 103400, false)]
        public void ppOptionsLightRaysBrightScalaronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$LightRayPostFX::brightScalar"] = thisobj["value"];
            thisobj["toolTip"] = "Value : " + thisobj["value"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "ppOptionsUpdateDOFSettings", "", 0, 103410, false)]
        public void ppOptionsUpdateDOFSettings()
            {
            coPostEffect DOFPostEffect = "DOFPostEffect";

            DOFPostEffectsetFocusParams(DOFPostEffect, fGlobal["$DOFPostFx::BlurMin"], fGlobal["$DOFPostFx::BlurMax"], fGlobal["$DOFPostFx::FocusRangeMin"], fGlobal["$DOFPostFx::FocusRangeMax"], fGlobal["$DOFPostFx::BlurCurveNear"]*-1.0f, fGlobal["$DOFPostFx::BlurCurveFar"]);


            DOFPostEffectsetAutoFocus(DOFPostEffect, bGlobal["$DOFPostFx::EnableAutoFocus"]);
            DOFPostEffectsetFocalDist(DOFPostEffect, "0");

            if (bGlobal["$PostFXManager::PostFX::EnableDOF"])
                DOFPostEffect.enable();
            else
                DOFPostEffect.disable();
            }


        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFEnableDOF", "onAction", "%this", 1, 103420, false)]
        public void ppOptionsDOFEnableDOFonAction(coGuiCheckBoxCtrl thisobj)
            {
            sGlobal["$PostFXManager::PostFX::EnableDOF"] = thisobj.getValue();
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFEnableAutoFocus", "onAction", "%this", 1, 103430, false)]
        public void ppOptionsDOFEnableAutoFocusonAction(coGuiCheckBoxCtrl thisobj)
            {
            sGlobal["$DOFPostFx::EnableAutoFocus"] = thisobj.getValue();
            DOFPostEffectsetAutoFocus("DOFPostEffect", thisobj.getValue().AsBool());
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFFarBlurMinSlider", "onMouseDragged", "%this", 1, 103440, false)]
        public void ppOptionsDOFFarBlurMinSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::BlurMin"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFFarBlurMaxSlider", "onMouseDragged", "%this", 1, 103450, false)]
        public void ppOptionsDOFFarBlurMaxSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::BlurMax"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFFocusRangeMinSlider", "onMouseDragged", "%this", 1, 103460, false)]
        public void ppOptionsDOFFocusRangeMinSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::FocusRangeMin"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFFocusRangeMaxSlider", "onMouseDragged", "%this", 1, 103470, false)]
        public void ppOptionsDOFFocusRangeMaxSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::FocusRangeMax"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFBlurCurveNearSlider", "onMouseDragged", "%this", 1, 103480, false)]
        public void ppOptionsDOFBlurCurveNearSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::BlurCurveNear"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }

        [Torque_Decorations.TorqueCallBack("", "ppOptionsDOFBlurCurveFarSlider", "onMouseDragged", "%this", 1, 103490, false)]
        public void ppOptionsDOFBlurCurveFarSlideronMouseDragged(coGuiSliderCtrl thisobj)
            {
            sGlobal["$DOFPostFx::BlurCurveFar"] = thisobj["value"];
            ppOptionsUpdateDOFSettings();
            }


        [Torque_Decorations.TorqueCallBack("", "ppOptionsEnableHDRDebug", "onAction", "%this", 1, 103500, false)]
        public void ppOptionsEnableHDRDebugonAction(coGuiCheckBoxCtrl thisobj)
            {
            if (thisobj.getValue().AsBool())
                ((coPostEffect)"LuminanceVisPostFX").enable();
            else
                ((coPostEffect)"LuminanceVisPostFX").disable();
            }

        [Torque_Decorations.TorqueCallBack("", "", "ppColorCorrection_selectFile", "", 0, 103510, false)]
        public void ppColorCorrection_selectFile()
            {
            string filter = "Image Files (*.png, *.jpg, *.dds, *.bmp, *.gif, *.jng. *.tga)|*.png;*.jpg;*.dds;*.bmp;*.gif;*.jng;*.tga|All Files (*.*)|*.*|";
            console.Call("getLoadFilename", new[] {filter, "ppColorCorrection_selectFileHandler"});
            }


        [Torque_Decorations.TorqueCallBack("", "", "ppColorCorrection_selectFileHandler", "%filename", 1, 103520, false)]
        public void ppColorCorrection_selectFileHandler(string filename)
            {
            if (filename == "" || !Util.isFile(filename))
                filename = default_color_correction;
            else
                filename = Util.makeRelativePath(filename, Util.getMainDotCsDir());

            sGlobal["$HDRPostFX::colorCorrectionRamp"] = filename;

            coGuiTextEditCtrl ctrl = ((coGuiControl)"PostFXManager").findObjectByInternalName("ColorCorrectionFileName", true);
            if (ctrl.isObject())
                ctrl.text =filename;
            }
        }
    }