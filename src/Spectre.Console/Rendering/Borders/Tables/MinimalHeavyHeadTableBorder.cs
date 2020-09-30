using System;

namespace Spectre.Console.Rendering
{
    /// <summary>
    /// Represents a minimal border with a heavy header.
    /// </summary>
    public sealed class MinimalHeavyHeadTableBorder : TableBorder
    {
        /// <inheritdoc/>
        public override TableBorder? SafeBorder => TableBorder.Minimal;

        /// <inheritdoc/>
        protected override string GetBorderPart(TableBorderPart part)
        {
            return part switch
            {
                TableBorderPart.HeaderTopLeft => " ",
                TableBorderPart.HeaderTop => " ",
                TableBorderPart.HeaderTopSeparator => " ",
                TableBorderPart.HeaderTopRight => " ",
                TableBorderPart.HeaderLeft => " ",
                TableBorderPart.HeaderSeparator => "│",
                TableBorderPart.HeaderRight => " ",
                TableBorderPart.HeaderBottomLeft => " ",
                TableBorderPart.HeaderBottom => "━",
                TableBorderPart.HeaderBottomSeparator => "┿",
                TableBorderPart.HeaderBottomRight => " ",
                TableBorderPart.CellLeft => " ",
                TableBorderPart.CellSeparator => "│",
                TableBorderPart.CellRight => " ",
                TableBorderPart.FooterBottomLeft => " ",
                TableBorderPart.FooterBottom => " ",
                TableBorderPart.FooterBottomSeparator => " ",
                TableBorderPart.FooterBottomRight => " ",
                _ => throw new InvalidOperationException("Unknown border part."),
            };
        }
    }
}