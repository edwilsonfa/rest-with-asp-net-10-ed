namespace RestWithASPNET10Ed.Utils {
    public class NumberHelper {

        public static bool isNumeric(string strNumber) {
            decimal decimalValue;
            bool isNumber = decimal.TryParse(
                strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue
                );//BR 10,5 - US 10.5
            return isNumber;
        }

        public static decimal ConvertToDecimal(string strNumber) {
            decimal decimalValue;
            if (decimal.TryParse(
                strNumber,
               System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out decimalValue)) {
                return decimalValue;
            }
            return 0;
        }

    }
}
