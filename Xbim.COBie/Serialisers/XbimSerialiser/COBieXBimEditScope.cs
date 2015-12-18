using System;
using Xbim.Ifc2x3.UtilityResource;
using Xbim.Ifc2x3.IO;

namespace Xbim.COBie.Serialisers.XbimSerialiser
{
    class COBieXBimEditScope : IDisposable
    {
        private IfcOwnerHistory ifcOwnerHistory {  get;  set; }
        private XbimModel Model {  get;  set; }

        public COBieXBimEditScope(XbimModel model, IfcOwnerHistory owner)
        {
            Model = model;
            ifcOwnerHistory = Model.OwnerHistoryAddObject;
            Model.OwnerHistoryAddObject = owner;
            
        }

        public void Dispose()
        {
            Model.OwnerHistoryAddObject = ifcOwnerHistory;
        }
    }
}
