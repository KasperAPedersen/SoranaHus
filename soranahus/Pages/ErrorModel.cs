// File: Pages/ErrorModel.cs
namespace soranahus.Pages
{
    public class ErrorModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}