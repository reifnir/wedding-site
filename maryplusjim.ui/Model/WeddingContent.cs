using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maryplusjim.ui.Model
{
    public class WeddingContent
    {
        internal static WeddingContent Default()
        {
            return new WeddingContent()
            {
                RsvpBody = "RsvpBody-Pellentesque tincidunt tempor fermentum. Nunc vehicula ut lec tus ac commodo cibus justo. Phasellus pulvinar tellus sed dictum semper. Donec vitae sapien quis nisl gravida finibus. Aenean in condimentum nisl, hendrerit aliquet quam.(1)",
                HeaderTitle = "HeaderTitle-Mary and Jim's Wedding(1)",
                HeaderDate = "HeaderDate-On May 28th · Hotel Monaco in Philadelphia, Pennsylvania(1)",
                OurStoryParagraphs = new List<string>()
                {
                    "Pellentesque tincidunt tempor fermentum. Nunc vehicula ut lectus ac commodo cibus justo. Phasellus pulvinar tellus sed dictum semper. Donec vitae sapien quis nisl gravida finibus. Aenean in condimentum nisl, hendrerit aliquet quam. Nulla diam arcu, ullamcorper eu euismod eget, vestibulum a lacus. Proin luctus ante et metus porttitor interdum.(1)",
                    "Donec tempor mi ut viverra vulputate. Sed tincidunt magna ex, pharetra congue magna maximus volutpat. Vestibulum suscipit tellus non purus facilisis, et faucibus metus congue. Nullam a quam tortor. We love each other. Phasellus nisl dolor, commodo a tincidunt vel, imperdiet non lacus. Curabitur sit amet posuere lectus, nec varius ipsum. Fusce pretium felis libero, at varius mauris efficitur quis. Sed tempor eleifend euismod. Aenean in condim entum nisl, hendrerit aliquet quam. Nulla diam arcu, ullamcorper eu euismod eget.(1)",
                    "Vivamus lobortis lectus mauris, feugiat feugiat enim efficitur at. Fusce vitae tempus ex. Vivamus nec tellus sed tellus convallis accumsan ac id nibh. Etiam in ante lorem. Donec vulputate turpis et leo porttitor tincidunt. Fusce felis mauris, auctor vitae odio et, mollis suscipit augue. Cum sociis natoque penatibus et magnis dis parturient montes.(1)"
                },
                OurHistory = new List<OurHistoryItem>()
                {
                    new OurHistoryItem() { }
                }
            };
        }

        public string HeaderTitle { get; set; }
        public string HeaderDate { get; private set; }

        public List<string> OurStoryParagraphs { get; set; } = new List<string>();

        public string RsvpBody { get; set; }

        public string HowWeMet { get; set; }

        public List<OurHistoryItem> OurHistory { get; set; } = new List<OurHistoryItem>();
        public string GalleryText { get; set; }
        public List<string> GalleryImages { get; set; }

        public string LocationHeader { get; set; }

        public string LocationFooter { get; set; }
    }

    public class OurHistoryItem
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime When { get; set; }
    }
}
