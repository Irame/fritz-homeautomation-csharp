using System.Xml.Serialization;

namespace Fritz.HomeAutomation.Enums
{
    /// <summary>
    /// Mode of the Switch
    /// </summary>
    public enum SwitchMode
    {
        /// <summary>
        /// Device is in auto mode
        /// </summary>
        [XmlEnum(Name = "auto")]
        Auto,

        /// <summary>
        /// Device is in manual mode
        /// </summary>
        [XmlEnum(Name = "manuell")]
        Manual
    }
}