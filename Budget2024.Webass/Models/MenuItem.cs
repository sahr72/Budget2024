namespace Budget2024.Webass.Models
{
    public class MenuItem
    {
        public string Title { get; set; } = string.Empty;
        public List<MenuItem>? SubMenuItems { get; set; }

        // Additional properties if needed
        // public string Icon { get; set; }
        // public string Url { get; set; }

        public MenuItem()
        {
            SubMenuItems = new List<MenuItem>();
        }
    }
}
