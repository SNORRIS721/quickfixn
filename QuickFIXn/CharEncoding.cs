namespace QuickFix
{
    public static class CharEncoding
    {
        public static System.Text.Encoding DefaultEncoding;

        static CharEncoding()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            DefaultEncoding = System.Text.Encoding.GetEncoding("iso-8859-1");
        }

        public static void setEncoding(string encoding)
        {
            DefaultEncoding = System.Text.Encoding.GetEncoding(encoding);
        }
    }
}
