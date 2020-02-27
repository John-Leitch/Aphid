
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
                                    public const string Country = "TG";
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
                            
                                        var cur = (Math.Abs(6.33333 - lat) + Math.Abs(1.53333 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(6.42611 - lat) + Math.Abs(1.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.03333 - lat) + Math.Abs(1.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.58333 - lat) + Math.Abs(1.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.5634 - lat) + Math.Abs(0.98399 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.98333 - lat) + Math.Abs(1.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.95 - lat) + Math.Abs(1.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.76806 - lat) + Math.Abs(1.10528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.35917 - lat) + Math.Abs(0.47083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.12874 - lat) + Math.Abs(1.22154 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.9 - lat) + Math.Abs(0.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.7525 - lat) + Math.Abs(1.32778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.55111 - lat) + Math.Abs(1.18611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.95778 - lat) + Math.Abs(1.04472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.86225 - lat) + Math.Abs(0.20762 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.25025 - lat) + Math.Abs(0.78213 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.35 - lat) + Math.Abs(1.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.58333 - lat) + Math.Abs(0.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.53333 - lat) + Math.Abs(1.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.22798 - lat) + Math.Abs(1.5919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.46667 - lat) + Math.Abs(0.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vogan", "24", 6.33333, 1.53333);
case 1: return new CityInfo("Tsévié", "24", 6.42611, 1.21333);
case 2: return new CityInfo("Tchamba", "22", 9.03333, 1.41667);
case 3: return new CityInfo("Tabligbo", "24", 6.58333, 1.5);
case 4: return new CityInfo("Sotouboua", "22", 8.5634, 0.98399);
case 5: return new CityInfo("Sokodé", "22", 8.98333, 1.13333);
case 6: return new CityInfo("Notsé", "25", 6.95, 1.16667);
case 7: return new CityInfo("Niamtougou", "23", 9.76806, 1.10528);
case 8: return new CityInfo("Sansanné-Mango", "26", 10.35917, 0.47083);
case 9: return new CityInfo("Lomé", "24", 6.12874, 1.22154);
case 10: return new CityInfo("Kpalimé", "25", 6.9, 0.63333);
case 11: return new CityInfo("Pagouda", "23", 9.7525, 1.32778);
case 12: return new CityInfo("Kara", "23", 9.55111, 1.18611);
case 13: return new CityInfo("Kandé", "23", 9.95778, 1.04472);
case 14: return new CityInfo("Dapaong", "26", 10.86225, 0.20762);
case 15: return new CityInfo("Bassar", "23", 9.25025, 0.78213);
case 16: return new CityInfo("Bafilo", "23", 9.35, 1.26667);
case 17: return new CityInfo("Badou", "25", 7.58333, 0.6);
case 18: return new CityInfo("Atakpamé", "25", 7.53333, 1.13333);
case 19: return new CityInfo("Aného", "24", 6.22798, 1.5919);
default: return new CityInfo("Amlamé", "25", 7.46667, 0.9);

                                    }                                        
                                }
                            
                        }
                    }
                