namespace App.Model
{
    using System.Collections.Generic;
    using App.Form;
    public class WeaponModel
    {
        
        public List<WeaponForm> GetWeapons()
        {
            List<WeaponForm> list = new List<WeaponForm>();

            return list;
        }

        public WeaponForm GetWeapon(int Id)
        {
            WeaponForm Wf = new WeaponForm();
            
            return Wf;
        }
    }
}