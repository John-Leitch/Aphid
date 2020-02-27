
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "LK";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(7.0281 - lat) + Math.Abs(79.9014 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(5.97501 - lat) + Math.Abs(80.42968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.7989 - lat) + Math.Abs(81.4808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.98918 - lat) + Math.Abs(79.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.7514 - lat) + Math.Abs(80.4971 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81667 - lat) + Math.Abs(80.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.13333 - lat) + Math.Abs(81.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0212 - lat) + Math.Abs(80.2503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5778 - lat) + Math.Abs(81.2289 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.02338 - lat) + Math.Abs(80.79738 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9999 - lat) + Math.Abs(80.2787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9371 - lat) + Math.Abs(80.6581 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.94946 - lat) + Math.Abs(80.75037 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.6858 - lat) + Math.Abs(80.4036 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.0362 - lat) + Math.Abs(79.8283 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.93965 - lat) + Math.Abs(81.00274 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.81667 - lat) + Math.Abs(80.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8905 - lat) + Math.Abs(79.9015 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9685 - lat) + Math.Abs(79.8836 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.7132 - lat) + Math.Abs(79.9026 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.97078 - lat) + Math.Abs(80.78286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2083 - lat) + Math.Abs(79.8358 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.933 - lat) + Math.Abs(79.9297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.84019 - lat) + Math.Abs(79.87116 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.773 - lat) + Math.Abs(79.8816 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8714 - lat) + Math.Abs(81.3487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1663 - lat) + Math.Abs(79.9533 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.3593 - lat) + Math.Abs(80.5103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.94851 - lat) + Math.Abs(80.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4698 - lat) + Math.Abs(80.6217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.848 - lat) + Math.Abs(79.9265 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4839 - lat) + Math.Abs(80.3683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.4688 - lat) + Math.Abs(80.0401 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.88297 - lat) + Math.Abs(79.90708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9269 - lat) + Math.Abs(79.9095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9329 - lat) + Math.Abs(79.8848 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9886 - lat) + Math.Abs(80.3286 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3961 - lat) + Math.Abs(80.3982 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9553 - lat) + Math.Abs(79.922 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2523 - lat) + Math.Abs(80.3436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.16992 - lat) + Math.Abs(79.88837 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4134 - lat) + Math.Abs(81.3346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2906 - lat) + Math.Abs(80.6336 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.048 - lat) + Math.Abs(79.8937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.5831 - lat) + Math.Abs(79.9593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.40902 - lat) + Math.Abs(81.83472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.2547 - lat) + Math.Abs(80.5242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.66845 - lat) + Math.Abs(80.00742 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.0744 - lat) + Math.Abs(79.8919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.7159 - lat) + Math.Abs(80.0626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.844 - lat) + Math.Abs(80.0024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1407 - lat) + Math.Abs(80.1012 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9909 - lat) + Math.Abs(79.883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8916 - lat) + Math.Abs(80.5955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.76566 - lat) + Math.Abs(80.95104 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9012 - lat) + Math.Abs(80.0852 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.1643 - lat) + Math.Abs(80.5696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.0897 - lat) + Math.Abs(79.9925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.0461 - lat) + Math.Abs(80.2103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7782 - lat) + Math.Abs(81.6038 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8756 - lat) + Math.Abs(81.0463 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.92825 - lat) + Math.Abs(80.5888 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.86 - lat) + Math.Abs(80.65167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.93548 - lat) + Math.Abs(79.84868 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.57583 - lat) + Math.Abs(79.79528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.4788 - lat) + Math.Abs(79.9828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.42598 - lat) + Math.Abs(79.99575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.7102 - lat) + Math.Abs(81.6924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.8964 - lat) + Math.Abs(79.9181 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9802 - lat) + Math.Abs(81.0577 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.31223 - lat) + Math.Abs(80.41306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.29754 - lat) + Math.Abs(81.68202 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.2355 - lat) + Math.Abs(80.0538 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.48088 - lat) + Math.Abs(80.12708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.845 - lat) + Math.Abs(80.7625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.73694 - lat) + Math.Abs(81.10279 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.94655 - lat) + Math.Abs(80.45831 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Welisara", "36", 7.0281, 79.9014);
case 1: return new CityInfo("Weligama", "34", 5.97501, 80.42968);
case 2: return new CityInfo("Wattegama", "35", 6.7989, 81.4808);
case 3: return new CityInfo("Wattala", "36", 6.98918, 79.89167);
case 4: return new CityInfo("Vavuniya", "38", 8.7514, 80.4971);
case 5: return new CityInfo("Valvedditturai", "38", 9.81667, 80.16667);
case 6: return new CityInfo("Vakarai", "37", 8.13333, 81.43333);
case 7: return new CityInfo("Unawatuna", "34", 6.0212, 80.2503);
case 8: return new CityInfo("Trincomalee", "37", 8.5778, 81.2289);
case 9: return new CityInfo("Tangalle", "34", 6.02338, 80.79738);
case 10: return new CityInfo("Talpe", "34", 5.9999, 80.2787);
case 11: return new CityInfo("Talawakele", "29", 6.9371, 80.6581);
case 12: return new CityInfo("Sigiriya", "29", 7.94946, 80.75037);
case 13: return new CityInfo("Ratnapura", "33", 6.6858, 80.4036);
case 14: return new CityInfo("Puttalam", "32", 8.0362, 79.8283);
case 15: return new CityInfo("Polonnaruwa", "30", 7.93965, 81.00274);
case 16: return new CityInfo("Point Pedro", "38", 9.81667, 80.23333);
case 17: return new CityInfo("Pita Kotte", "36", 6.8905, 79.9015);
case 18: return new CityInfo("Peliyagoda", "36", 6.9685, 79.8836);
case 19: return new CityInfo("Panadura", "36", 6.7132, 79.9026);
case 20: return new CityInfo("Nuwara Eliya", "29", 6.97078, 80.78286);
case 21: return new CityInfo("Negombo", "36", 7.2083, 79.8358);
case 22: return new CityInfo("Mulleriyawa", "36", 6.933, 79.9297);
case 23: return new CityInfo("Dehiwala-Mount Lavinia", "36", 6.84019, 79.87116);
case 24: return new CityInfo("Moratuwa", "36", 6.773, 79.8816);
case 25: return new CityInfo("Monaragala", "35", 6.8714, 81.3487);
case 26: return new CityInfo("Minuwangoda", "36", 7.1663, 79.9533);
case 27: return new CityInfo("Mihintale", "30", 8.3593, 80.5103);
case 28: return new CityInfo("Matara", "34", 5.94851, 80.53528);
case 29: return new CityInfo("Matale", "29", 7.4698, 80.6217);
case 30: return new CityInfo("Maharagama", "36", 6.848, 79.9265);
case 31: return new CityInfo("Kurunegala", "32", 7.4839, 80.3683);
case 32: return new CityInfo("Kuliyapitiya", "32", 7.4688, 80.0401);
case 33: return new CityInfo("Sri Jayewardenepura Kotte", "36", 6.88297, 79.90708);
case 34: return new CityInfo("Kotikawatta", "36", 6.9269, 79.9095);
case 35: return new CityInfo("Kolonnawa", "36", 6.9329, 79.8848);
case 36: return new CityInfo("Koggala", "34", 5.9886, 80.3286);
case 37: return new CityInfo("Kilinochchi", "38", 9.3961, 80.3982);
case 38: return new CityInfo("Kelaniya", "36", 6.9553, 79.922);
case 39: return new CityInfo("Kegalle", "33", 7.2523, 80.3436);
case 40: return new CityInfo("Katunayaka", "36", 7.16992, 79.88837);
case 41: return new CityInfo("Kataragama", "35", 6.4134, 81.3346);
case 42: return new CityInfo("Kandy", "29", 7.2906, 80.6336);
case 43: return new CityInfo("Kandana", "36", 7.048, 79.8937);
case 44: return new CityInfo("Kalutara", "36", 6.5831, 79.9593);
case 45: return new CityInfo("Kalmunai", "37", 7.40902, 81.83472);
case 46: return new CityInfo("Kadugannawa", "29", 7.2547, 80.5242);
case 47: return new CityInfo("Jaffna", "38", 9.66845, 80.00742);
case 48: return new CityInfo("Ja Ela", "36", 7.0744, 79.8919);
case 49: return new CityInfo("Horana South", "36", 6.7159, 80.0626);
case 50: return new CityInfo("Homagama", "36", 6.844, 80.0024);
case 51: return new CityInfo("Hikkaduwa", "34", 6.1407, 80.1012);
case 52: return new CityInfo("Hendala", "36", 6.9909, 79.883);
case 53: return new CityInfo("Hatton", "29", 6.8916, 80.5955);
case 54: return new CityInfo("Haputale", "35", 6.76566, 80.95104);
case 55: return new CityInfo("Hanwella Ihala", "36", 6.9012, 80.0852);
case 56: return new CityInfo("Gampola", "29", 7.1643, 80.5696);
case 57: return new CityInfo("Gampaha", "36", 7.0897, 79.9925);
case 58: return new CityInfo("Galle", "34", 6.0461, 80.2103);
case 59: return new CityInfo("Eravur Town", "37", 7.7782, 81.6038);
case 60: return new CityInfo("Ella Town", "35", 6.8756, 81.0463);
case 61: return new CityInfo("Devinuwara", "34", 5.92825, 80.5888);
case 62: return new CityInfo("Dambulla", "29", 7.86, 80.65167);
case 63: return new CityInfo("Colombo", "36", 6.93548, 79.84868);
case 64: return new CityInfo("Chilaw", "32", 7.57583, 79.79528);
case 65: return new CityInfo("Beruwala", "36", 6.4788, 79.9828);
case 66: return new CityInfo("Bentota", "34", 6.42598, 79.99575);
case 67: return new CityInfo("Batticaloa", "37", 7.7102, 81.6924);
case 68: return new CityInfo("Battaramulla South", "36", 6.8964, 79.9181);
case 69: return new CityInfo("Badulla", "35", 6.9802, 81.0577);
case 70: return new CityInfo("Anuradhapura", "30", 8.31223, 80.41306);
case 71: return new CityInfo("Ampara", "37", 7.29754, 81.68202);
case 72: return new CityInfo("Ambalangoda", "34", 6.2355, 80.0538);
case 73: return new CityInfo("Horawala Junction", "36", 6.48088, 80.12708);
case 74: return new CityInfo("Padaviya Divisional Secretariat", "", 8.845, 80.7625);
case 75: return new CityInfo("Wellawaya", "35", 6.73694, 81.10279);
default: return new CityInfo("Mirissa city", "34", 5.94655, 80.45831);

                                    }                                        
                                }
                            
                        }
                    }
                