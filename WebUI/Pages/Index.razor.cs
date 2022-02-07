using Application;

namespace WebUI.Pages
{
    public partial class Index
    {
        private RoomModel _roomForm = new();


        private Room? _room;

        protected override void OnInitialized()
        {
            base.OnInitialized();
        }

        private void HandleValidSubmit()
        {
            _room = new Room(_roomForm.Length, _roomForm.Width, _roomForm.Height);
        }
    }
}