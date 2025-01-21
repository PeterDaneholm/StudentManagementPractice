namespace StudentManagement.Utility;
using StudentManagement.Domain.Enums;

public static class ParseInput
{
    public static bool InputToEnum<TEnum> (string input, TEnum result) where TEnum : struct
    {
        if (Enum.TryParse(input, true, out TEnum parsedEnum))
        {
            result = parsedEnum;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }
}