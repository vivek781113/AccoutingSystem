namespace AccountingSystem.Models
{
    public class Project
    {
        public BillingMode BillingMode { get; set; }
    }

    public enum BillingMode
    {
        /// <summary>
        /// Hours are logged by people working on the project and client is billed based on a fixed rate by the hour
        /// </summary>
        TIME_AND_MATERIAL,
        /// <summary>
        /// Project has milestones and clients are billed a fixed amount when a milestone is completed
        /// </summary>
        Milestone_Based
    }
}
