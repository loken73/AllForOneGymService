using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AllForOneGymService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITrainerService" in both code and config file together.
    [ServiceContract]
    public interface ITrainerService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/DoWork2", ResponseFormat = WebMessageFormat.Json)]
        string DoWork();
    }
}
