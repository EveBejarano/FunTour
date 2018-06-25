using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FunTourDataLayer.EventCompany
{
    public class EventCompany
    {

        public EventCompany()
        {
            Even
            this.ReservedTicket = new HashSet<ReservedTicket>();
            this.TravelPackage = new HashSet<TravelPackage>();
        }

        [Key]
        public int Id_EventCompany { get; set; }

        public string Name { get; set; }

        public string Information { get; set; }

        public string APIURLToGetEvents { get; set; }
        public string APIURLToReserveTickets { get; set; }

        public string APIURLToCancelReservation { get; set; }

        public string APIURLToReserveTicketByClient { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event> Event { get; set; }

    }
}
