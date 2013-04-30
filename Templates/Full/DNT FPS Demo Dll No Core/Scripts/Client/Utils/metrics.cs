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
        /// Shortcut for typi1ng dbgSetParameters with the default values torsion uses.
        [Torque_Decorations.TorqueCallBack("", "", "initmetrics", "", 0, 36000, true)]
        public void initmetrics()
            {
            //con.error("------------------------>LOADING FRAMEOVERLAYGUI!!!!!!!!!!!!!!!!!!!!!");
            Util.exec("core/art/gui/FrameOverlayGui.gui", false, false);
            }


        [Torque_Decorations.TorqueCallBack("", "", "fpsMetricsCallback", "", 0, 36000, false)]
        public string fpsMetricsCallback()
            {
            return "  | FPS |  " + sGlobal["$fps::real"] + "  max: " + sGlobal["$fps::realMax"] + "  min: " + sGlobal["$fps::realMin"] + "  mspf: " + (1000.0/dGlobal["$fps::real"]);
            }

        [Torque_Decorations.TorqueCallBack("", "", "gfxMetricsCallback", "", 0, 36000, false)]
        public string gfxMetricsCallback()
            {
            return "  | GFX |" + "  PolyCount: " + sGlobal["$GFXDeviceStatistics::polyCount"] + "  DrawCalls: " + sGlobal["$GFXDeviceStatistics::drawCalls"] + "  RTChanges: " + sGlobal["$GFXDeviceStatistics::renderTargetChanges"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "terrainMetricsCallback", "", 0, 36000, false)]
        public string terrainMetricsCallback()
            {
            return "  | Terrain |" + "  Cells: " + sGlobal["$TerrainBlock::cellsRendered"] + "  Override Cells: " + sGlobal["$TerrainBlock::overrideCells"] + "  DrawCalls: " + sGlobal["$TerrainBlock::drawCalls"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "netMetricsCallback", "", 0, 36000, false)]
        public string netMetricsCallback()
            {
            return "  | Net |" + "  BitsSent: " + sGlobal["$Stats::netBitsSent"] + "  BitsRcvd: " + sGlobal["$Stats::netBitsReceived"] + "  GhostUpd: " + sGlobal["$Stats::netGhostUpdates"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "groundCoverMetricsCallback", "", 0, 36000, false)]
        public string groundCoverMetricsCallback()
            {
            return "  | GroundCover |" + "  Cells: " + sGlobal["$GroundCover::renderedCells"] + "  Billboards: " + sGlobal["$GroundCover::renderedBillboards"] + "  Batches: " + sGlobal["$GroundCover::renderedBatches"] + "  Shapes: " + sGlobal["$GroundCover::renderedShapes"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "sfxMetricsCallback", "", 0, 36000, false)]
        public string sfxMetricsCallback()
            {
            return "  | SFX |" + "  Sounds: " + sGlobal["$SFX::numSounds"] + "  Lists: " + (iGlobal["$SFX::numSources"] - iGlobal["$SFX::numSounds"] - iGlobal["$SFX::Device::fmodNumEventSource"]) + "  Events: " + sGlobal["$SFX::fmodNumEventSources"] + "  Playing: " + sGlobal["$SFX::numPlaying"] + "  Culled: " + sGlobal["$SFX::numCulled"] + "  Voices: " + sGlobal["$SFX::numVoices"] + "  Buffers: " + sGlobal["$SFX::Device::numBuffers"] + "  Memory: " + (dGlobal["$SFX::Device::numBufferBytes"]/1024.0/1024.0) + " MB" + "  Time/S: " + sGlobal["$SFX::sourceUpdateTime"] + "  Time/P: " + sGlobal["$SFX::parameterUpdateTime"] + "  Time/A: " + sGlobal["$SFX::ambientUpdateTime"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "sfxSourcesMetricsCallback", "", 0, 36000, false)]
        public string sfxSourcesMetricsCallback()
            {
            return Util.sfxDumpSourcesToString(false);
            }

        [Torque_Decorations.TorqueCallBack("", "", "sfxStatesMetricsCallback", "", 0, 36000, false)]
        public string sfxStatesMetricsCallback()
            {
            return "  | SFXStates |" + sGlobal["sfxGetActiveStates"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "timeMetricsCallback", "", 0, 36000, false)]
        public string timeMetricsCallback()
            {
            return "  | Time |" + "  Sim Time: " + Util._getSimTime() + "  Mod: " + (Util._getSimTime()%32);
            }

        [Torque_Decorations.TorqueCallBack("", "", "reflectMetricsCallback", "", 0, 36000, false)]
        public string reflectMetricsCallback()
            {
            return "  | REFLECT |" + "  Objects: " + sGlobal["$Reflect::numObjects"] + "  Visible: " + sGlobal["$Reflect::numVisible"] + "  Occluded: " + sGlobal["$Reflect::numOccluded"] + "  Updated: " + sGlobal["$Reflect::numUpdated"] + "  Elapsed: " + sGlobal["$Reflect::elapsed"] + "\n" + "  Allocated: " + sGlobal["$Reflect::renderTargetsAllocated"] + "  Pooled: " + sGlobal["$Reflect::poolSize"] + "\n" + "  " + sGlobal["$Reflect::textureStats"].Split(' ')[1] + "\t" + "  " + sGlobal["$Reflect::textureStats"].Split(' ')[2] + "MB" + "\t" + "  " + sGlobal["$Reflect::textureStats"].Split(' ')[0];
            }

        [Torque_Decorations.TorqueCallBack("", "", "decalMetricsCallback", "", 0, 36000, false)]
        public string decalMetricsCallback()
            {
            return "  | DECAL |" + " Batches: " + sGlobal["$Decal::Batches"] + " Buffers: " + sGlobal["$Decal::Buffers"] + " DecalsRendered: " + sGlobal["$Decal::DecalsRendered"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "renderMetricsCallback", "", 0, 36000, false)]
        public string renderMetricsCallback()
            {
            return "  | Render |" + "  Int: " + sGlobal["$RenderMetrics::RIT_Interior"] + "  IntDL: " + sGlobal["$RenderMetrics::RIT_InteriorDynamicLighting"] + "  Mesh: " + sGlobal["$RenderMetrics::RIT_Mesh"] + "  MeshDL: " + sGlobal["$RenderMetrics::RIT_MeshDynamicLighting"] + "  Shadow: " + sGlobal["$RenderMetrics::RIT_Shadow"] + "  Sky: " + sGlobal["$RenderMetrics::RIT_Sky"] + "  Obj: " + sGlobal["$RenderMetrics::RIT_Object"] + "  ObjT: " + sGlobal["$RenderMetrics::RIT_ObjectTranslucent"] + "  Decal: " + sGlobal["$RenderMetrics::RIT_Decal"] + "  Water: " + sGlobal["$RenderMetrics::RIT_Water"] + "  Foliage: " + sGlobal["$RenderMetrics::RIT_Foliage"] + "  Trans: " + sGlobal["$RenderMetris::RIT_Translucent"] + "  Custom: " + sGlobal["$RenderMetrics::RIT_Custom"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "shadowMetricsCallback", "", 0, 36000, false)]
        public string shadowMetricsCallback()
            {
            return "  | Shadow |" + "  Active: " + sGlobal["$ShadowStats::activeMaps"] + "  Updated: " + sGlobal["$ShadowStats::updatedMaps"] + "  PolyCount: " + sGlobal["$ShadowStats::polyCount"] + "  DrawCalls: " + sGlobal["$ShadowStats::drawCalls"] + "  RTChanges: " + sGlobal["$ShadowStats::rtChanges"] + "  PoolTexCount: " + sGlobal["$ShadowStats::poolTexCount"] + "  PoolTexMB: " + sGlobal["$ShadowStats::poolTexMemory"] + "MB";
            }

        [Torque_Decorations.TorqueCallBack("", "", "basicShadowMetricsCallback", "", 0, 36000, false)]
        public string basicShadowMetricsCallback()
            {
            return "  | Shadow |" + "  Active: " + sGlobal["$BasicLightManagerStats::activePlugins"] + "  Updated: " + sGlobal["$BasicLightManagerStats::shadowsUpdated"] + "  Elapsed Ms: " + sGlobal["$BasicLightManagerStats::elapsedUpdateMs"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "lightMetricsCallback", "", 0, 36000, false)]
        public string lightMetricsCallback()
            {
            return "  | Deferred Lights |" + "  Active: " + sGlobal["$lightMetrics::activeLights"] + "  Culled: " + sGlobal["$lightMetrics::culledLights"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "particleMetricsCallback", "", 0, 36000, false)]
        public string particleMetricsCallback()
            {
            return "  | Particles |" + "  # Simulated " + sGlobal["$particle::numSimulated"];
            }

        [Torque_Decorations.TorqueCallBack("", "", "partMetricsCallback", "", 0, 36000, false)]
        public string partMetricsCallback()
            {
            return particleMetricsCallback();
            }

        [Torque_Decorations.TorqueCallBack("", "", "audioMetricsCallback", "", 0, 36000, false)]
        public string audioMetricsCallback()
            {
            return sfxMetricsCallback();
            }

        [Torque_Decorations.TorqueCallBack("", "", "videoMetricsCallback", "", 0, 36000, false)]
        public string videoMetricsCallback()
            {
            return gfxMetricsCallback();
            }

        // Add a metrics HUD.  %expr can be a vector of names where each element
        // must have a corresponding '<name>MetricsCallback()' function defined
        // that will be called on each update of the GUI control.  The results
        // of each function are stringed together.
        //
        // Example: metrics( "fps gfx" );
        [Torque_Decorations.TorqueCallBack("", "", "metrics", "%expr", 1, 36000, false)]
        public void metrics(string expr)
            {
            string metricsExpr = "";
            if (expr != "")
                {
                foreach (string name in expr.Split(' '))
                    {
                    string cb = name.Trim() + "MetricsCallback";
                    if (!console.isFunction(cb))
                        {
                        console.error("metrics - undefined callback: " + cb);
                        }
                    else
                        {
                        cb = cb + "()";
                        if (metricsExpr.Length > 0)
                            metricsExpr += " NL ";
                        metricsExpr += cb;


                        //fpsMetricsCallback() NL gfxMetricsCallback() @ " "
                        }
                    }
                metricsExpr += " @ \" \"";
                }
            if (metricsExpr != "")
                {
                ((coGuiCanvas)"Canvas").pushDialog("FrameOverlayGui", "1000");
                ((coGuiConsoleTextCtrl)"TextOverlayControl").setValue(metricsExpr);
                }
            else
                {
                ((coGuiCanvas)"Canvas").popDialog("FrameOverlayGui");
                }
            }
        }
    }