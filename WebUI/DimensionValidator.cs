using System;
using System.ComponentModel.DataAnnotations;

namespace WebUI
{
    public class DimensionValidator : ValidationAttribute
    {
        private readonly string _name;
        public DimensionValidator(string fieldName)
        {
            _name = fieldName;
        }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult($"{_name} Dimension is null",
            new[] { validationContext.MemberName! });
            }
            if (value.GetType() != typeof(decimal))
            {
                throw new InvalidOperationException();
            }
            if ((decimal)value <= 0)
            {
                return new ValidationResult($"{_name} Dimension is not valid",
            new[] { validationContext.MemberName! });
            }
            return null;
        }
    }
}
