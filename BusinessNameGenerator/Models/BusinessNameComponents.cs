using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessNameGenerator.Models
{
    public class BusinessNameComponents
    {
        public string PlaceName { get; set; }
        public string LegalWord { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string Prefix { get; set; }
        public string Suffix { get; set; }
        public int[] NameTemplateIds { get; set; } = new int[] {0, 0, 0};

        public string GetNameFromTemplate(int templateId)
        {
            switch (templateId)
            {
                case 0:
                    return $"{Prefix} {Suffix} of {PlaceName} {LegalWord}";
                case 1:
                    return $"{Surname1[0]}&{Surname2[0]} {Suffix} {LegalWord}";
                case 2:
                    return $"{Surname1} {Suffix}";
                case 3:
                    return $"{PlaceName} {Suffix} {LegalWord}";
                case 4:
                    return $"{Surname1} {Prefix} {Suffix}";
                default:
                    throw new Exception($"{templateId} is an invalid TemplateId");
            }
        }

        public string this[int templateNumber] => GetNameFromTemplate(NameTemplateIds[templateNumber]);

    }
}
