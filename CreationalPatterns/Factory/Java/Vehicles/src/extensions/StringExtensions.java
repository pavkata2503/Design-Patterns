package extensions;

public class StringExtensions {
    public static String splitPascalCaseString(String pascalCaseString) {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < pascalCaseString.length(); i++) {
            char currentChar = pascalCaseString.charAt(i);

            if (i != 0 && Character.isUpperCase(currentChar)
                    && !Character.isUpperCase(pascalCaseString.charAt(i - 1))) {
                result.append(' ');
            }

            result.append(currentChar);
        }

        return result.toString();
    }
}