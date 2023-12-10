namespace HomWork_EF_Eman
{
     class program
    {
        static void Main(string[] args)
        {
            var _conext = new ApplictionDbContext1();
            var part = new Part
            {
                Name = "new name",
                price=200,
                Quantity=200
                
     
            };
            var p = _conext.Parts.Find(1);
            part.Name = "name 1";
            _conext.Parts.Remove(p);//دالة الحذف
            _conext.Parts.Add(part);//دالة الاضافة

            var car = new Car
            {
              Model="model 10",Year=20,Gear=20,Km=400


            };
            var car1 = _conext.Cars.Find(1);
            car.Model = "model 10";
            _conext.Cars.Remove(car);//دالة الحذف
            _conext.Cars.Add(car);//دالة الاضافة

            var customer = new Customer
            {
                Name = "Ahmad",Address="syrai",Age=40
               


            };
            var customer1 = _conext.Customer.Find(1);
            part.Name = "Ahmed";
            _conext.Customer.Remove(customer);//دالة الحذف
            _conext.Customer.Add(customer);//دالة الاضافة






            _conext.SaveChanges();
            
            
        }
    }
}

