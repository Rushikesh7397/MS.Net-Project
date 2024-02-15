using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NGO_HubConnect.Models;

namespace NGO_HubConnect.Controllers
{
    [Authorize]
    public class EventContainerController : Controller
    {
        public IActionResult EventView()
        {
            List<EventContainer> events = new List<EventContainer>()
            {

    new EventContainer
    {
        Event_Name = "Healing Hearts Blood Drive",
        Organisation_Name = "Red Cross",
        DateTime = DateTime.Now.AddDays(7),
        Location = "City Hospital",
        EventType = "Blood Donation",
        Description = "Join the Healing Hearts Blood Drive, your compassionate act brings healing to those facing health challenges. Donating blood is a powerful symbol of empathy and solidarity, fostering a community of care and support. #BloodDrive #CommunityCares",
        Phone = "123-456-7890",
        Image = "~/image/Blood Donation.jpg"
    },
    new EventContainer
    {
        Event_Name = "Garbage-Free Zone Campaign",
        Organisation_Name = "Green Earth",
        DateTime = DateTime.Now.AddMonths(1),
        Location = "City Park",
        EventType = "Cleanliness Campaign",
        Description = "Join the Garbage-Free Zone Campaign! Be part of the movement to create a cleaner environment. Your actions contribute to a waste-free community, fostering a sense of responsibility and pride. Let's work together for a greener and healthier future. #CleanEnvironment #CommunityPride",
        Phone = "987-654-3210",
        Image = "~/image/Cleanliness.jpg"
    },
    new EventContainer
    {
        Event_Name = "Empower Tomorrow: Fundraising Gala",
        Organisation_Name = "Charity Foundation",
        DateTime = DateTime.Now.AddMonths(2),
        Location = "Community Center",
        EventType = "Fund Raiser",
        Description = "Empower Tomorrow: Fundraising Gala invites you to a night of impact and philanthropy. Join us for an evening filled with elegance and purpose, where your support fuels empowerment initiatives. Together, let's make a lasting difference and shape a brighter tomorrow. #EmpowerTomorrow #FundraisingGala",
        Phone = "555-123-4567",
        Image = "~/image/Fund Raiser.jpg"
    },
    new EventContainer
    {
        Event_Name = "EduSpark: Igniting Minds for Right Education",
        Organisation_Name = "Education for All",
        DateTime = DateTime.Now.AddMonths(3),
        Location = "Local School",
        EventType = "Right Education for Children",
        Description = "Empower a brighter future! Join the \"Right Education for Children\" initiative, where education becomes a beacon of hope. Your support ensures children receive quality education, breaking barriers and creating opportunities. Together, let's build a foundation for a promising tomorrow. #EducationForAll",
        Phone = "999-888-7777",
        Image = "~/image/Right Education.jpg"
    },
    new EventContainer
    {
        Event_Name = "Green Horizon: Community Tree Plantation Initiative",
        Organisation_Name = "Green Warriors",
        DateTime = DateTime.Now.AddMonths(4),
        Location = "City Streets",
        EventType = "Tree Plantation",
        Description = "Participate in Green Horizon: Community Tree Plantation Initiative and contribute to a greener future. Your involvement helps create a sustainable environment, fostering community unity. Join us in planting trees, symbolizing our shared commitment to a healthier planet. #TreePlantation #GreenCommunity",
        Phone = "123-987-4567",
        Image = "~/image/Tree Plantation.jpg"
    },
    new EventContainer
    {
        Event_Name = "Self-Reliance Circle for Women",
        Organisation_Name = "Empower Women",
        DateTime = DateTime.Now.AddMonths(5),
        Location = "Community Hall",
        EventType = "Women Empowerment",
        Description = "EmpowerHER: Elevate women through our initiative, fostering education, entrepreneurship, and equality. Join us in creating a supportive community that empowers women to achieve their full potential and contribute to positive societal change. Together, we build a future of strength and success.",
        Phone = "777-444-1111",
        Image = "~/image/Women Empowerment.jpg"
    },
    new EventContainer
    {
        Event_Name = "Women's Independence Forum",
        Organisation_Name = "Self Reliance Foundation",
        DateTime = DateTime.Now.AddMonths(6),
        Location = "Empowerment Center",
        EventType = "Empowering Women towards Self Reliance",
        Description ="Empowering Women towards Self-Reliance: A transformative initiative fostering independence. Join us in equipping women with skills, resources, and support networks, empowering them to build self-reliant futures. Together, we create a community where every woman's potential is realized. #WomenEmpowerment",
        Phone = "111-222-3333",
        Image = "~/image/Women self Relaince.jpg"
    },
    new EventContainer
    {
        Event_Name = "Wellness at Your Doorstep: Health Check Day",
        Organisation_Name = "HealthCare Foundation",
        DateTime = DateTime.Now.AddMonths(3),
        Location = "Local Clinic",
        EventType = "Community Health Checkup",
        Description = "Participate in our Community Health Checkup event, a vital initiative for well-being. Ensure your health and that of your neighbors. Free checkups, expert consultations, and a shared commitment to a healthier community await you! #HealthCheckup #CommunityWellness",
        Phone = "444-555-6666",
        Image = "~/image/Health Checkup.jpg"
    }

        };
            return View(events);
        }
    }
}
