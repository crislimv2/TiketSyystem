using System;
using System.ComponentModel.DataAnnotations;

public class ValidEnumAttribute : ValidationAttribute
{
  private readonly Type _enumType;

  public ValidEnumAttribute(Type enumType)
  {
    if (!enumType.IsEnum)
      throw new ArgumentException("Type must be an enum");

    _enumType = enumType;
  }

  protected override ValidationResult IsValid(object value, ValidationContext validationContext)
  {
    if (value == null)
    {
      return new ValidationResult(ErrorMessage ?? "The field is required.");
    }

    if (!Enum.IsDefined(_enumType, value))
    {
      return new ValidationResult(ErrorMessage ?? "Invalid enum value.");
    }

    return ValidationResult.Success;
  }
}