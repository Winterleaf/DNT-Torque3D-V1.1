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
using System.ComponentModel;
using WinterLeaf.Classes;
using WinterLeaf.Containers;

#endregion

namespace WinterLeaf.tsObjects
    {
    /// <summary>
    /// 
    /// </summary>
    internal class tsObjectConvertercoGuiObjectView : TypeConverter
        {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="sourceType"></param>
        /// <returns></returns>
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
            return (typeof (string) == sourceType);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="culture"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public override object ConvertFrom(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value)
            {
            if (value is string)
                {
                return new coGuiObjectView(value as string);
                }

            return null;
            }
        }


    /// <summary>
    /// 
    /// </summary>
    [TypeConverter(typeof (tsObjectConvertercoGuiObjectView))]
    public class coGuiObjectView : coGuiTSCtrl
        {
        private ColorF _lightAmbient;
        private ColorF _lightColor;
        private Point3F _lightDirection;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiObjectView(string simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiObjectView(uint simobjectid) : base(simobjectid)
            {
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="simobjectid"></param>
        internal coGuiObjectView(int simobjectid) : base(simobjectid)
            {
            }


        /// <summary>
        /// The animation sequence to play on the model. 
        /// </summary>
        public String animSequence
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".animSequence").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".animSequence", value.AsString()); }
            }

        /// <summary>
        /// Multiplier for mouse camera operations. 
        /// </summary>
        public float cameraSpeed
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".cameraSpeed").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".cameraSpeed", value.AsString()); }
            }

        /// <summary>
        /// Ambient color of the sunlight used to render the model. 
        /// </summary>
        public ColorF lightAmbient
            {
            get
                {
                if (_lightAmbient != null)
                    _lightAmbient.DetachAllEvents();
                _lightAmbient = dnTorque.self.GetVar(_mSimObjectId + ".lightAmbient").AsColorF();
                _lightAmbient.OnChangeNotification += _lightAmbient_OnChangeNotification;
                return _lightAmbient;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".lightAmbient", value.AsString()); }
            }

        /// <summary>
        /// Diffuse color of the sunlight used to render the model. 
        /// </summary>
        public ColorF lightColor
            {
            get
                {
                if (_lightColor != null)
                    _lightColor.DetachAllEvents();
                _lightColor = dnTorque.self.GetVar(_mSimObjectId + ".lightColor").AsColorF();
                _lightColor.OnChangeNotification += _lightColor_OnChangeNotification;
                return _lightColor;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".lightColor", value.AsString()); }
            }

        /// <summary>
        /// Direction from which the model is illuminated. 
        /// </summary>
        public Point3F lightDirection
            {
            get
                {
                if (_lightDirection != null)
                    _lightDirection.DetachAllEvents();
                _lightDirection = dnTorque.self.GetVar(_mSimObjectId + ".lightDirection").AsPoint3F();
                _lightDirection.OnChangeNotification += _lightDirection_OnChangeNotification;
                return _lightDirection;
                }
            set { dnTorque.self.SetVar(_mSimObjectId + ".lightDirection", value.AsString()); }
            }

        /// <summary>
        /// Minimum distance below which the camera will not zoom in further. 
        /// </summary>
        public float maxOrbitDiststance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".maxOrbitDiststance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".maxOrbitDiststance", value.AsString()); }
            }

        /// <summary>
        /// Maxiumum distance to which the camera can be zoomed out. 
        /// </summary>
        public float minOrbitDiststance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".minOrbitDiststance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".minOrbitDiststance", value.AsString()); }
            }

        /// <summary>
        /// Name of node on primary model to which to mount the secondary shape. 
        /// </summary>
        public String mountedNode
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mountedNode").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mountedNode", value.AsString()); }
            }

        /// <summary>
        /// Optional shape file to mount on the primary model (e.g. weapon). 
        /// </summary>
        public String mountedShapeFile
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mountedShapeFile").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mountedShapeFile", value.AsString()); }
            }

        /// <summary>
        /// Skin name used on mounted shape file. 
        /// </summary>
        public String mountedSkin
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".mountedSkin").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".mountedSkin", value.AsString()); }
            }

        /// <summary>
        /// Distance from which to render the model. 
        /// </summary>
        public float orbitDiststance
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".orbitDiststance").AsFloat(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".orbitDiststance", value.AsString()); }
            }

        /// <summary>
        /// The object model shape file to show in the view. 
        /// </summary>
        public String shapeFile
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".shapeFile").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".shapeFile", value.AsString()); }
            }

        /// <summary>
        /// The skin to use on the object model. 
        /// </summary>
        public String skin
            {
            get { return dnTorque.self.GetVar(_mSimObjectId + ".skin").AsString(); }
            set { dnTorque.self.SetVar(_mSimObjectId + ".skin", value.AsString()); }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator ==(coGuiObjectView ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return object.ReferenceEquals(simobjectid, null);
            return ts.Equals(simobjectid);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
            {
            throw new NotImplementedException();
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
            {
            return (this._mSimObjectId == (string) myReflections.ChangeType(obj, typeof (string)));
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="simobjectid"></param>
        /// <returns></returns>
        public static bool operator !=(coGuiObjectView ts, string simobjectid)
            {
            if (object.ReferenceEquals(ts, null))
                return !object.ReferenceEquals(simobjectid, null);
            return !ts.Equals(simobjectid);
            }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator string(coGuiObjectView ts)
            {
            if (object.ReferenceEquals(ts, null))
                return "0";
            return ts._mSimObjectId;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiObjectView(string ts)
            {
            return new coGuiObjectView(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator int(coGuiObjectView ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            int i;
            return int.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiObjectView(int ts)
            {
            return new coGuiObjectView(ts);
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator uint(coGuiObjectView ts)
            {
            if (object.ReferenceEquals(ts, null))
                return 0;
            uint i;
            return uint.TryParse(ts._mSimObjectId, out i) ? i : 0;
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public static implicit operator coGuiObjectView(uint ts)
            {
            return new coGuiObjectView(ts);
            }

        private void _lightAmbient_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".lightAmbient", e.NewValue);
            }

        private void _lightColor_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".lightColor", e.NewValue);
            }

        private void _lightDirection_OnChangeNotification(object o, Notifier.ChangeNotificationEventArgs e)
            {
            dnTorque.self.SetVar(_mSimObjectId + ".lightDirection", e.NewValue);
            }

        /// <summary>
        /// @brief Return the current multiplier for camera zooming and rotation.
        ///    @tsexample
        ///    // Request the current camera zooming and rotation multiplier value
        ///    %multiplier = %thisGuiObjectView.getCameraSpeed();
        ///    @endtsexample
        ///    @return Camera zooming / rotation multiplier value.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public float getCameraSpeed()
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getCameraSpeed(_mSimObjectId);
            }

        /// <summary>
        /// @brief Return the model displayed in this view.
        ///    @tsexample
        ///    // Request the displayed model name from the GuiObjectView object.
        ///    %modelName = %thisGuiObjectView.getModel();
        ///    @endtsexample
        ///    @return Name of the displayed model.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public string getModel()
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getModel(_mSimObjectId);
            }

        /// <summary>
        /// @brief Return the name of the mounted model.
        ///    @tsexample
        ///    // Request the name of the mounted model from the GuiObjectView object
        ///    %mountedModelName = %thisGuiObjectView.getMountedModel();
        ///    @endtsexample
        ///    @return Name of the mounted model.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public string getMountedModel()
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getMountedModel(_mSimObjectId);
            }

        /// <summary>
        /// @brief Return the name of skin used on the mounted model.
        ///    @tsexample
        ///    // Request the skin name from the model mounted on to the main model in the control
        ///    %mountModelSkin = %thisGuiObjectView.getMountSkin();
        ///    @endtsexample
        ///    @return Name of the skin used on the mounted model.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public string getMountSkin(int param1, int param2)
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getMountSkin(_mSimObjectId, param1, param2);
            }

        /// <summary>
        /// @brief Return the current distance at which the camera orbits the object.
        ///    @tsexample
        ///    // Request the current orbit distance
        ///    %orbitDistance = %thisGuiObjectView.getOrbitDistance();
        ///    @endtsexample
        ///    @return The distance at which the camera orbits the object.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public float getOrbitDistance()
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getOrbitDistance(_mSimObjectId);
            }

        /// <summary>
        /// @brief Return the name of skin used on the primary model.
        ///    @tsexample
        ///    // Request the name of the skin used on the primary model in the control
        ///    %skinName = %thisGuiObjectView.getSkin();
        ///    @endtsexample
        ///    @return Name of the skin used on the primary model.
        ///    @see GuiControl)
        /// 
        /// </summary>
        public string getSkin()
            {
            return TorqueScriptTemplate.m_ts.fnGuiObjectView_getSkin(_mSimObjectId);
            }

        /// <summary>
        /// @brief Sets the multiplier for the camera rotation and zoom speed.
        ///    @param factor Multiplier for camera rotation and zoom speed.
        ///    @tsexample
        ///    // Set the factor value
        ///    %factor = \"0.75\";
        ///    // Inform the GuiObjectView object to set the camera speed.
        ///    %thisGuiObjectView.setCameraSpeed(%factor);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setCameraSpeed(float factor)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setCameraSpeed(_mSimObjectId, factor);
            }

        /// <summary>
        /// @brief Set the light ambient color on the sun object used to render the model.
        ///    @param color Ambient color of sunlight.
        ///    @tsexample
        ///    // Define the sun ambient color value
        ///    %color = \"1.0 0.4 0.6\";
        ///    // Inform the GuiObjectView object to set the sun ambient color to the requested value
        ///    %thisGuiObjectView.setLightAmbient(%color);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setLightAmbient(ColorF color)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setLightAmbient(_mSimObjectId, color.AsString());
            }

        /// <summary>
        /// @brief Set the light color on the sun object used to render the model.
        ///    @param color Color of sunlight.
        ///    @tsexample
        ///    // Set the color value for the sun
        ///    %color = \"1.0 0.4 0.5\";
        ///    // Inform the GuiObjectView object to change the sun color to the defined value
        ///    %thisGuiObjectView.setLightColor(%color);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setLightColor(ColorF color)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setLightColor(_mSimObjectId, color.AsString());
            }

        /// <summary>
        /// @brief Set the light direction from which to light the model.
        ///    @param direction XYZ direction from which the light will shine on the model
        ///    @tsexample
        ///    // Set the light direction
        ///    %direction = \"1.0 0.2 0.4\"
        ///    // Inform the GuiObjectView object to change the light direction to the defined value
        ///    %thisGuiObjectView.setLightDirection(%direction);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setLightDirection(Point3F direction)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setLightDirection(_mSimObjectId, direction.AsString());
            }

        /// <summary>
        /// @brief Sets the model to be displayed in this control.
        ///    @param shapeName Name of the model to display.
        ///    @tsexample
        ///    // Define the model we want to display
        ///    %shapeName = \"gideon.dts\";
        ///    // Tell the GuiObjectView object to display the defined model
        ///    %thisGuiObjectView.setModel(%shapeName);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setModel(string shapeName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setModel(_mSimObjectId, shapeName);
            }

        /// <summary>
        /// @brief Mounts the given model to the specified mount point of the primary model displayed in this control.
        ///    Detailed description
        ///    @param shapeName Name of the model to mount.
        ///    @param mountNodeIndexOrName Index or name of the mount point to be mounted to. If index, corresponds to \"mountN\" in your shape where N is the number passed here.
        ///    @tsexample
        ///    // Set the shapeName to mount
        ///    %shapeName = \"GideonGlasses.dts\"
        ///    // Set the mount node of the primary model in the control to mount the new shape at
        ///    %mountNodeIndexOrName = \"3\";
        ///    //OR:
        ///    %mountNodeIndexOrName = \"Face\";
        ///    // Inform the GuiObjectView object to mount the shape at the specified node.
        ///    %thisGuiObjectView.setMount(%shapeName,%mountNodeIndexOrName);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setMount(string shapeName, string mountNodeIndexOrName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setMount(_mSimObjectId, shapeName, mountNodeIndexOrName);
            }

        /// <summary>
        /// @brief Sets the model to be mounted on the primary model.
        ///    @param shapeName Name of the model to mount.
        ///    @tsexample
        ///    // Define the model name to mount
        ///    %modelToMount = \"GideonGlasses.dts\";
        ///    // Inform the GuiObjectView object to mount the defined model to the existing model in the control
        ///    %thisGuiObjectView.setMountedModel(%modelToMount);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setMountedModel(string shapeName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setMountedModel(_mSimObjectId, shapeName);
            }

        /// <summary>
        /// @brief Sets the skin to use on the mounted model.
        ///    @param skinName Name of the skin to set on the model mounted to the main model in the control
        ///    @tsexample
        ///    // Define the name of the skin
        ///    %skinName = \"BronzeGlasses\";
        ///    // Inform the GuiObjectView Control of the skin to use on the mounted model
        ///    %thisGuiObjectViewCtrl.setMountSkin(%skinName);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setMountSkin(string skinName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setMountSkin(_mSimObjectId, skinName);
            }

        /// <summary>
        /// @brief Sets the distance at which the camera orbits the object. Clamped to the acceptable range defined in the class by min and max orbit distances.
        ///    Detailed description
        ///    @param distance The distance to set the orbit to (will be clamped).
        ///    @tsexample
        ///    // Define the orbit distance value
        ///    %orbitDistance = \"1.5\";
        ///    // Inform the GuiObjectView object to set the orbit distance to the defined value
        ///    %thisGuiObjectView.setOrbitDistance(%orbitDistance);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setOrbitDistance(float distance)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setOrbitDistance(_mSimObjectId, distance);
            }

        /// <summary>
        /// @brief Sets the animation to play for the viewed object.
        ///    @param indexOrName The index or name of the animation to play.
        ///    @tsexample
        ///    // Set the animation index value, or animation sequence name.
        ///    %indexVal = \"3\";
        ///    //OR:
        ///    %indexVal = \"idle\";
        ///    // Inform the GuiObjectView object to set the animation sequence of the object in the control.
        ///    %thisGuiObjectVew.setSeq(%indexVal);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setSeq(string indexOrName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setSeq(_mSimObjectId, indexOrName);
            }

        /// <summary>
        /// @brief Sets the skin to use on the model being displayed.
        ///    @param skinName Name of the skin to use.
        ///    @tsexample
        ///    // Define the skin we want to apply to the main model in the control
        ///    %skinName = \"disco_gideon\";
        ///    // Inform the GuiObjectView control to update the skin the to defined skin
        ///    %thisGuiObjectView.setSkin(%skinName);
        ///    @endtsexample
        ///    @see GuiControl)
        /// 
        /// </summary>
        public void setSkin(string skinName)
            {
            TorqueScriptTemplate.m_ts.fnGuiObjectView_setSkin(_mSimObjectId, skinName);
            }
        }
    }