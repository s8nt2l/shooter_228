using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace CompleteProject {
    public enum GunType {
        SimpleGun,
        Ak47,
        Laser
    }
    public class Gun {
        public static string string_type;
        public static int damagePerShot;
        public static float timeBetweenBullets;
        public static float range;
        public static float effectsDisplayTime;     
        //public static int bulletsCount;
        public static int maxBulletsCount;

        static public void SetType(string string_type_) {
            string_type = string_type_;
        }

        public Gun() {
            string_type = "no weapon";
        }

        virtual public void Shoot() {

        }
        
    }
    public class Ak47 : Gun {
        public Ak47() {
            SetType("Ak47");
            damagePerShot = 25;
            timeBetweenBullets = 0.07f;
            range = 100f;
            effectsDisplayTime = 0.1f;
            maxBulletsCount = 35;
        }
        public override void Shoot() {

        }
    }
    public class Laser : Gun {
        public Laser() {
            SetType("Laser");
            damagePerShot = 5;
            timeBetweenBullets = 0.00001f;
            range = 100f;
            effectsDisplayTime = 0.00001f;
            maxBulletsCount = 500;
        }
        public override void Shoot() {

        }
    }
    public class SimpleWeapon : Gun {
        public SimpleWeapon() {
            SetType("SimpleWeapon");
            damagePerShot = 50;
            timeBetweenBullets = 0.5f;
            range = 100f;
            effectsDisplayTime = 0.5f;
            maxBulletsCount = 6;
        }
        public override void Shoot() {

        }
    }
    
    public class GunManager : MonoBehaviour {
        Text text;
        static public Gun current_gun;
        static public void SetType(GunType type) {
            switch (type) {
                case (GunType.Ak47):
                    current_gun = new Ak47();
                    break;
                case(GunType.Laser):
                    current_gun = new Laser();
                    break;
                case (GunType.SimpleGun):
                    current_gun = new SimpleWeapon();
                    break;
                default:
                    break;
            }
            BulletManager.Reload();
        }
        // Start is called before the first frame update
        void Start() {
            text = GetComponent<Text>();
            SetType(GunType.Laser);
        }
        void Update() {
            text.text = "Weapon:" + Gun.string_type;
        }
        
    }
    
}
/*namespace CompleteProject {
    static public class Gun {
        public static int damagePerShot;
        public static float timeBetweenBullets;
        public static float range;
        public static float effectsDisplayTime;     
        //public static int bulletsCount;
        public static int maxBulletsCount;
        
    }
    public enum GunType {
        SimpleGun, 
        Ak47, 
        Laser
    }
    public class GunManager : MonoBehaviour {
        Text text;
        
        static public void SetType(GunType type) {
            switch (type) {
                case (GunType.Ak47):
                    Gun.damagePerShot = 25;
                    Gun.timeBetweenBullets = 0.07f;
                    Gun.range = 100f;
                    Gun.effectsDisplayTime = 0.1f;
                    Gun.maxBulletsCount = 35;
                    break;
                case(GunType.Laser):
                    Gun.damagePerShot = 5;
                    Gun.timeBetweenBullets = 0.00001f;
                    Gun.range = 100f;
                    Gun.effectsDisplayTime = 0.00001f;
                    Gun.maxBulletsCount = 500;
                    break;
                case (GunType.SimpleGun):
                    Gun.damagePerShot = 50;
                    Gun.timeBetweenBullets = 0.5f;
                    Gun.range = 100f;
                    Gun.effectsDisplayTime = 0.5f;
                    Gun.maxBulletsCount = 6;
                    break;
                default:
                    break;
            }
            BulletManager.Reload();
        }
        // Start is called before the first frame update
        void Start() {
            text = GetComponent<Text>();
            SetType(GunType.Laser);
        }
        void Update() {
            text.text = "Weapon:" + Gun.maxBulletsCount;
        }
        
    }
    
}*/

//******alst
/*
namespace CompleteProject {
    public class GunManager : MonoBehaviour {
        string type;
        Text text;
        protected void SetType(string type) {
            this.type = type;
        }
        // Start is called before the first frame update
        void Start() {
            text = GetComponent<Text>();
            type = "Simple gun";            
        }
        void Update() {
            text.text = "Weapon:" + type;
        }
        virtual public int Get_damagePerShot() {
            return 0;
        }
        virtual public float Get_timeBetweenBullets() {
            return 0;
        }
        virtual public float Get_range() {
            return 0;
        }
        virtual public float Get_effectsDisplayTime() {
            return 0;
        }
        // Update is called once per frame
        
    }
    public class SimpleGun : GunManager {
        SimpleGun() {
            SetType("Simple gun1");
            BulletManager.max_count = 34;
            BulletManager.count = 34;
        }
        public override int Get_damagePerShot() {
            return 25;
        }

        public override float Get_timeBetweenBullets() {
            return 0.17f;
        }

        public override float Get_range() {
            return 100f;
        }

        public override float Get_effectsDisplayTime() {
            return 0.12f;
        }

        
    }

    public class Ak47 : GunManager {
        Ak47() {
            SetType("ak-47");
            BulletManager.count = 50;
            BulletManager.max_count = 50;
        }
        public override int Get_damagePerShot() {
            return 5;
        }

        public override float Get_timeBetweenBullets() {
            return 0.07f;
        }

        public override float Get_range() {
            return 50f;
        }

        public override float Get_effectsDisplayTime() {
            return 0.12f;
        }


    }
}*/
