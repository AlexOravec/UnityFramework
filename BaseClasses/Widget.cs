namespace BaseClasses
{
    public class Widget : Object
    {
        // Show widget
        public void Show()
        {
            gameObject.SetActive(true);
        }

        // Hide widget
        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}