using CarProject.Services;

namespace CarProject.Models
{
    class Car : AbstractTransport
    {
        #region fields
        [TitleField("Horse power")]
        public int HorsePower { get; set; }

        [TitleField("Engine")]
        public string Engine { get; set; }

        #endregion

        public override void SaveItem()
        {
            if(this.ID == 0)
                DataBaseService.GetInstanse().SaveItem<Car>(this);
            else
                DataBaseService.GetInstanse().UpdateItem<Car>(this);
        }
        public override void RemoveItem()
        {
            DataBaseService.GetInstanse().RemoveItem<Car>(this);
        }
    }
}
