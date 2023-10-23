// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StructuredDocumentTag.cs">
//   Copyright (c) 2023 Aspose.Words for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Aspose.Words.Cloud.Sdk.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// DTO container with a StructuredDocumentTag.
    /// </summary>
    public class StructuredDocumentTag : NodeLink, IModel
    {
        /// <summary>
        /// Gets or sets the appearance of a structured document tag.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AppearanceEnum
        {
            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,

            /// <summary>
            /// Enum value "BoundingBox"
            /// </summary>
            BoundingBox,

            /// <summary>
            /// Enum value "Tags"
            /// </summary>
            Tags,

            /// <summary>
            /// Enum value "Hidden"
            /// </summary>
            Hidden,
        }

        /// <summary>
        /// Gets or sets format in which the date for a date SDT is stored when the SDT is bound to an XML node in the document's data store.
        /// Default value is Aspose.Words.Markup.SdtDateStorageFormat.DateTime.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DateStorageFormatEnum
        {
            /// <summary>
            /// Enum value "Date"
            /// </summary>
            Date,

            /// <summary>
            /// Enum value "DateTime"
            /// </summary>
            DateTime,

            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,

            /// <summary>
            /// Enum value "Text"
            /// </summary>
            Text,
        }

        /// <summary>
        /// Gets or sets the type of calendar for this SDT. Default is Aspose.Words.Markup.SdtCalendarType.Default.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalendarTypeEnum
        {
            /// <summary>
            /// Enum value "Default"
            /// </summary>
            Default,

            /// <summary>
            /// Enum value "Gregorian"
            /// </summary>
            Gregorian,

            /// <summary>
            /// Enum value "GregorianArabic"
            /// </summary>
            GregorianArabic,

            /// <summary>
            /// Enum value "GregorianMeFrench"
            /// </summary>
            GregorianMeFrench,

            /// <summary>
            /// Enum value "GregorianUs"
            /// </summary>
            GregorianUs,

            /// <summary>
            /// Enum value "GregorianXlitEnglish"
            /// </summary>
            GregorianXlitEnglish,

            /// <summary>
            /// Enum value "GregorianXlitFrench"
            /// </summary>
            GregorianXlitFrench,

            /// <summary>
            /// Enum value "Hebrew"
            /// </summary>
            Hebrew,

            /// <summary>
            /// Enum value "Hijri"
            /// </summary>
            Hijri,

            /// <summary>
            /// Enum value "Japan"
            /// </summary>
            Japan,

            /// <summary>
            /// Enum value "Korea"
            /// </summary>
            Korea,

            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Saka"
            /// </summary>
            Saka,

            /// <summary>
            /// Enum value "Taiwan"
            /// </summary>
            Taiwan,

            /// <summary>
            /// Enum value "Thai"
            /// </summary>
            Thai,
        }

        /// <summary>
        /// Gets or sets the level at which this SDT occurs in the document tree.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            /// <summary>
            /// Enum value "Unknown"
            /// </summary>
            Unknown,

            /// <summary>
            /// Enum value "Inline"
            /// </summary>
            Inline,

            /// <summary>
            /// Enum value "Block"
            /// </summary>
            Block,

            /// <summary>
            /// Enum value "Row"
            /// </summary>
            Row,

            /// <summary>
            /// Enum value "Cell"
            /// </summary>
            Cell,
        }

        /// <summary>
        /// Gets or sets type of this Structured document tag.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SdtTypeEnum
        {
            /// <summary>
            /// Enum value "None"
            /// </summary>
            None,

            /// <summary>
            /// Enum value "Bibliography"
            /// </summary>
            Bibliography,

            /// <summary>
            /// Enum value "Citation"
            /// </summary>
            Citation,

            /// <summary>
            /// Enum value "Equation"
            /// </summary>
            Equation,

            /// <summary>
            /// Enum value "DropDownList"
            /// </summary>
            DropDownList,

            /// <summary>
            /// Enum value "ComboBox"
            /// </summary>
            ComboBox,

            /// <summary>
            /// Enum value "Date"
            /// </summary>
            Date,

            /// <summary>
            /// Enum value "BuildingBlockGallery"
            /// </summary>
            BuildingBlockGallery,

            /// <summary>
            /// Enum value "DocPartObj"
            /// </summary>
            DocPartObj,

            /// <summary>
            /// Enum value "Group"
            /// </summary>
            Group,

            /// <summary>
            /// Enum value "Picture"
            /// </summary>
            Picture,

            /// <summary>
            /// Enum value "RichText"
            /// </summary>
            RichText,

            /// <summary>
            /// Enum value "PlainText"
            /// </summary>
            PlainText,

            /// <summary>
            /// Enum value "Checkbox"
            /// </summary>
            Checkbox,

            /// <summary>
            /// Enum value "RepeatingSection"
            /// </summary>
            RepeatingSection,

            /// <summary>
            /// Enum value "RepeatingSectionItem"
            /// </summary>
            RepeatingSectionItem,

            /// <summary>
            /// Enum value "EntityPicker"
            /// </summary>
            EntityPicker,
        }

        /// <summary>
        /// Gets or sets Aspose.Words.Markup.SdtListItemCollection associated with this SDT.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.ComboBox or Aspose.Words.Markup.SdtType.DropDownList SDT types.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual List<StructuredDocumentTagListItem> ListItems { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether current state of the Checkbox SDT. Default value for this property.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Checkbox SDT types.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual bool? Checked { get; set; }

        /// <summary>
        /// Gets or sets the appearance of a structured document tag.
        /// </summary>
        public virtual AppearanceEnum? Appearance { get; set; }

        /// <summary>
        /// Gets or sets the language format for the date displayed in this SDT.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual int? DateDisplayLocale { get; set; }

        /// <summary>
        /// Gets or sets String that represents the format in which dates are displayed. Can not be null. The dates for English (U.S.) is "mm/dd/yyyy".
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual string DateDisplayFormat { get; set; }

        /// <summary>
        /// Gets or sets the full date and time last entered into this SDT.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual DateTime? FullDate { get; set; }

        /// <summary>
        /// Gets or sets the friendly name associated with this SDT. Can not be null.
        /// </summary>
        public virtual string Title { get; set; }

        /// <summary>
        /// Gets or sets format in which the date for a date SDT is stored when the SDT is bound to an XML node in the document's data store.
        /// Default value is Aspose.Words.Markup.SdtDateStorageFormat.DateTime.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual DateStorageFormatEnum? DateStorageFormat { get; set; }

        /// <summary>
        /// Gets or sets type of building block for this SDT. Can not be null.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.BuildingBlockGallery and Aspose.Words.Markup.SdtType.DocPartObj SDT types.
        /// It is read-only for SDT of the document part type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual string BuildingBlockGallery { get; set; }

        /// <summary>
        /// Gets or sets category of building block for this SDT node. Can not be null.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.BuildingBlockGallery and Aspose.Words.Markup.SdtType.DocPartObj SDT types.
        /// It is read-only for SDT of the document part type. For all other SDT types exception will occur.
        /// </summary>
        public virtual string BuildingBlockCategory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this SDT allows multiple lines of text.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.RichText and Aspose.Words.Markup.SdtType.PlainText SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual bool? Multiline { get; set; }

        /// <summary>
        /// Gets or sets the color of the structured document tag.
        /// </summary>
        public virtual string Color { get; set; }

        /// <summary>
        /// Gets or sets the name of the style applied to the structured document tag.
        /// </summary>
        public virtual string StyleName { get; set; }

        /// <summary>
        /// Gets or sets the type of calendar for this SDT. Default is Aspose.Words.Markup.SdtCalendarType.Default.
        /// Accessing this property will only work for Aspose.Words.Markup.SdtType.Date SDT type.
        /// For all other SDT types exception will occur.
        /// </summary>
        public virtual CalendarTypeEnum? CalendarType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this SDT shall be removed from the WordProcessingML document when its contents are modified.
        /// </summary>
        public virtual bool? IsTemporary { get; set; }

        /// <summary>
        /// Gets or sets the level at which this SDT occurs in the document tree.
        /// </summary>
        public virtual LevelEnum? Level { get; set; }

        /// <summary>
        /// Gets or sets type of this Structured document tag.
        /// </summary>
        public virtual SdtTypeEnum? SdtType { get; set; }

        /// <summary>
        /// Gets or sets Name of the Aspose.Words.BuildingBlocks.BuildingBlock containing placeholder text.
        /// Aspose.Words.BuildingBlocks.BuildingBlock with this name Aspose.Words.BuildingBlocks.BuildingBlock.Name has to be present in the Aspose.Words.Document.GlossaryDocument otherwise System.InvalidOperationException will occur.
        /// </summary>
        public virtual string PlaceholderName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether, this property will prohibit a user from deleting this SDT.
        /// </summary>
        public virtual bool? LockContentControl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether, this property will prohibit a user from editing the contents of this SDT.
        /// </summary>
        public virtual bool? LockContents { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the content of this SDT shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT).
        /// If set to true, this state shall be resumed (showing placeholder text) upon opening his document.
        /// </summary>
        public virtual bool? IsShowingPlaceholderText { get; set; }

        /// <summary>
        /// Gets or sets a tag associated with the current SDT node. Can not be null.
        /// A tag is an arbitrary string which applications can associate with SDT in order to identify it without providing a visible friendly name.
        /// </summary>
        public virtual string Tag { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only persistent numerical Id for this SDT.
        /// Id attribute shall follow these rules:
        /// - The document shall retain SDT ids only if the whole document is cloned Aspose.Words.Document.Clone.
        /// - During Aspose.Words.DocumentBase.ImportNode(Aspose.Words.Node,System.Boolean)
        /// - Id shall be retained if import does not cause conflicts with other SDT Ids in the target document.
        /// - If multiple SDT nodes specify the same decimal number value for the Id attribute, then the first SDT in the document shall maintain this original Id, and all subsequent
        /// - SDT nodes shall have new identifiers assigned to them when the document is loaded.
        /// - During standalone SDT Aspose.Words.Markup.StructuredDocumentTag.Clone(System.Boolean,Aspose.Words.INodeCloningListener) operation new unique ID will be generated for the cloned SDT node.
        /// - If Id is not specified in the source document, then the SDT node shall have a new unique identifier assigned to it when the document is loaded.
        /// </summary>
        public virtual int? Id { get; set; }

        /// <summary>
        /// Gets a string that represents the XML contained within the node in the Aspose.Words.SaveFormat.FlatOpc format.
        /// </summary>
        public virtual string WordOpenXML { get; }


        /// <summary>
        /// Validating required properties in the model.
        /// </summary>
        public override void Validate()
        {
            base.Validate();

            if (this.ListItems != null)
            {
                foreach (var elementListItems in this.ListItems)
                {
                    elementListItems?.Validate();
                }
            }
























        }

        /// <summary>
        /// Get the string presentation of the object.
        /// </summary>
        /// <returns>String presentation of the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StructuredDocumentTag {\n");
            sb.Append("  Link: ").Append(this.Link).Append("\n");
            sb.Append("  NodeId: ").Append(this.NodeId).Append("\n");
            sb.Append("  ListItems: ").Append(this.ListItems).Append("\n");
            sb.Append("  Checked: ").Append(this.Checked).Append("\n");
            sb.Append("  Appearance: ").Append(this.Appearance).Append("\n");
            sb.Append("  DateDisplayLocale: ").Append(this.DateDisplayLocale).Append("\n");
            sb.Append("  DateDisplayFormat: ").Append(this.DateDisplayFormat).Append("\n");
            sb.Append("  FullDate: ").Append(this.FullDate).Append("\n");
            sb.Append("  Title: ").Append(this.Title).Append("\n");
            sb.Append("  DateStorageFormat: ").Append(this.DateStorageFormat).Append("\n");
            sb.Append("  BuildingBlockGallery: ").Append(this.BuildingBlockGallery).Append("\n");
            sb.Append("  BuildingBlockCategory: ").Append(this.BuildingBlockCategory).Append("\n");
            sb.Append("  Multiline: ").Append(this.Multiline).Append("\n");
            sb.Append("  Color: ").Append(this.Color).Append("\n");
            sb.Append("  StyleName: ").Append(this.StyleName).Append("\n");
            sb.Append("  CalendarType: ").Append(this.CalendarType).Append("\n");
            sb.Append("  IsTemporary: ").Append(this.IsTemporary).Append("\n");
            sb.Append("  Level: ").Append(this.Level).Append("\n");
            sb.Append("  SdtType: ").Append(this.SdtType).Append("\n");
            sb.Append("  PlaceholderName: ").Append(this.PlaceholderName).Append("\n");
            sb.Append("  LockContentControl: ").Append(this.LockContentControl).Append("\n");
            sb.Append("  LockContents: ").Append(this.LockContents).Append("\n");
            sb.Append("  IsShowingPlaceholderText: ").Append(this.IsShowingPlaceholderText).Append("\n");
            sb.Append("  Tag: ").Append(this.Tag).Append("\n");
            sb.Append("  Id: ").Append(this.Id).Append("\n");
            sb.Append("  WordOpenXML: ").Append(this.WordOpenXML).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
