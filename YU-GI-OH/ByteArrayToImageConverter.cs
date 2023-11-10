namespace YU_GI_OH {
    public class ByteArrayToImageConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is byte[] bytes) {
                return ImageSource.FromStream(() => new MemoryStream(bytes));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
