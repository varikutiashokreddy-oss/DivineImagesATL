namespace DivineImagesATL.Web.Models
{
    public sealed class SiteContent
    {
        public BrandContent Brand { get; set; } = new();
        public HeaderContent Header { get; set; } = new();
        public FooterContent Footer { get; set; } = new();
        public ContactInfo Contact { get; set; } = new();

        public HomePageContent Home { get; set; } = new();
        public ServicesPageContent Services { get; set; } = new();
        public PatientsPageContent Patients { get; set; } = new();
        public AttorneysPageContent Attorneys { get; set; } = new();
        public AboutPageContent About { get; set; } = new();
        public MriPageContent Mri { get; set; } = new();
        public ContactPageContent ContactPage { get; set; } = new();
    }

    public sealed class BrandContent
    {
        public string Name { get; set; } = string.Empty;
        public string Tagline { get; set; } = string.Empty;
        public string LogoText { get; set; } = string.Empty;
    }

    public sealed class HeaderContent
    {
        public List<NavItem> NavItems { get; set; } = [];
        public string PrimaryButtonText { get; set; } = string.Empty;
        public string PrimaryButtonUrl { get; set; } = string.Empty;
    }

    public sealed class FooterContent
    {
        public string CallToActionTitle { get; set; } = string.Empty;
        public string CallToActionText { get; set; } = string.Empty;
        public string Copyright { get; set; } = string.Empty;
        public string VeteranText { get; set; } = string.Empty;
    }

    public sealed class NavItem
    {
        public string Text { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }

    public sealed class ContactInfo
    {
        public string Phone { get; set; } = string.Empty;
        public string Fax { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string AddressLine1 { get; set; } = string.Empty;
        public string AddressLine2 { get; set; } = string.Empty;
        public string OfficeHours { get; set; } = string.Empty;
        public string MapUrl { get; set; } = string.Empty;
        public string FacebookUrl { get; set; } = string.Empty;
        public string InstagramUrl { get; set; } = string.Empty;
    }

    public sealed class HeroSection
    {
        public string Eyebrow { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string PrimaryButtonText { get; set; } = string.Empty;
        public string PrimaryButtonUrl { get; set; } = string.Empty;
        public string SecondaryButtonText { get; set; } = string.Empty;
        public string SecondaryButtonUrl { get; set; } = string.Empty;
    }

    public sealed class PageHero
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
    }

    public sealed class QuickAction
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public bool IsExternal { get; set; }
    }

    public sealed class PricingPackage
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string StartingPrice { get; set; } = string.Empty;
        public string CtaText { get; set; } = string.Empty;
        public string CtaUrl { get; set; } = string.Empty;
    }

    public sealed class InsuranceSection
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public List<string> AcceptedPlans { get; set; } = [];
        public string SelfPayNote { get; set; } = string.Empty;
    }

    public sealed class ComfortSection
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = [];
    }

    public sealed class Testimonial
    {
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public string Quote { get; set; } = string.Empty;
    }

    public sealed class AttorneyHighlight
    {
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public List<string> Highlights { get; set; } = [];
        public string CtaText { get; set; } = string.Empty;
        public string CtaUrl { get; set; } = string.Empty;
    }

    public sealed class HomePageContent
    {
        public HeroSection Hero { get; set; } = new();
        public List<QuickAction> QuickActions { get; set; } = [];
        public string PricingTitle { get; set; } = string.Empty;
        public string PricingSubtitle { get; set; } = string.Empty;
        public List<PricingPackage> PricingPackages { get; set; } = [];
        public InsuranceSection Insurance { get; set; } = new();
        public ComfortSection Comfort { get; set; } = new();
        public string TestimonialsTitle { get; set; } = string.Empty;
        public List<Testimonial> Testimonials { get; set; } = [];
        public AttorneyHighlight AttorneyHighlight { get; set; } = new();
    }

    public sealed class ServiceDetail
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Items { get; set; } = [];
    }

    public sealed class ServicesPageContent
    {
        public PageHero Hero { get; set; } = new();
        public List<string> ServiceHighlights { get; set; } = [];
        public List<ServiceDetail> ServiceDetails { get; set; } = [];
    }

    public sealed class InfoBlock
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> Bullets { get; set; } = [];
    }

    public sealed class FAQItem
    {
        public string Question { get; set; } = string.Empty;
        public string Answer { get; set; } = string.Empty;
    }

    public sealed class PatientsPageContent
    {
        public PageHero Hero { get; set; } = new();
        public string RegistrationFormText { get; set; } = string.Empty;
        public string RegistrationFormUrl { get; set; } = string.Empty;
        public List<InfoBlock> VisitBlocks { get; set; } = [];
        public List<FAQItem> Faqs { get; set; } = [];
        public string BottomCtaTitle { get; set; } = string.Empty;
        public string BottomCtaText { get; set; } = string.Empty;
        public string BottomCtaUrl { get; set; } = string.Empty;
    }

    public sealed class StatItem
    {
        public string Value { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
    }

    public sealed class BenefitItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public sealed class ProcessStep
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public sealed class AttorneysPageContent
    {
        public PageHero Hero { get; set; } = new();
        public List<StatItem> Stats { get; set; } = [];
        public List<BenefitItem> Benefits { get; set; } = [];
        public List<ProcessStep> ProcessSteps { get; set; } = [];
        public string BottomCtaTitle { get; set; } = string.Empty;
        public string BottomCtaText { get; set; } = string.Empty;
        public string BottomCtaUrl { get; set; } = string.Empty;
    }

    public sealed class CoreValue
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public sealed class AboutPageContent
    {
        public PageHero Hero { get; set; } = new();
        public string StoryTitle { get; set; } = string.Empty;
        public string Story { get; set; } = string.Empty;
        public List<CoreValue> Values { get; set; } = [];
    }

    public sealed class MriArea
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public sealed class MriPageContent
    {
        public PageHero Hero { get; set; } = new();
        public string Intro { get; set; } = string.Empty;
        public List<BenefitItem> Benefits { get; set; } = [];
        public List<MriArea> Areas { get; set; } = [];
        public List<FAQItem> Faqs { get; set; } = [];
    }

    public sealed class ContactPageContent
    {
        public PageHero Hero { get; set; } = new();
        public string Intro { get; set; } = string.Empty;
        public string FormTitle { get; set; } = string.Empty;
        public string FormSubtitle { get; set; } = string.Empty;
    }
}
