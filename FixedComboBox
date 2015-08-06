public class FixedComboBox : ComboBox
    {
        private int fixedIndex = 0;
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            if (SelectedIndex != -1)
            {
                fixedIndex = SelectedIndex;
            }
            else
            {
                SelectedIndex = fixedIndex;
            }
            base.OnSelectedIndexChanged(e);

        }
    }
