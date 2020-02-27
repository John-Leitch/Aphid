
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
                                    public const string Country = "CV";
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
                            
                                        var cur = (Math.Abs(14.87139 - lat) + Math.Abs(-24.69556 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(15.13823 - lat) + Math.Abs(-23.21158 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.61583 - lat) + Math.Abs(-24.29833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.56622 - lat) + Math.Abs(-24.35793 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.27881 - lat) + Math.Abs(-23.75192 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.8961 - lat) + Math.Abs(-24.49556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.02438 - lat) + Math.Abs(-23.5625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.59796 - lat) + Math.Abs(-22.90509 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.13333 - lat) + Math.Abs(-23.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.17611 - lat) + Math.Abs(-22.91722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.1825 - lat) + Math.Abs(-25.065 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.93152 - lat) + Math.Abs(-23.51254 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.01969 - lat) + Math.Abs(-25.06471 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.03389 - lat) + Math.Abs(-24.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.20171 - lat) + Math.Abs(-25.09217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(17.15026 - lat) + Math.Abs(-25.02007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.0836 - lat) + Math.Abs(-23.63236 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.89014 - lat) + Math.Abs(-24.98042 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.89054 - lat) + Math.Abs(-24.29343 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(14.91531 - lat) + Math.Abs(-23.60527 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.18613 - lat) + Math.Abs(-23.59228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1 - lat) + Math.Abs(-23.68333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.06694 - lat) + Math.Abs(-23.58917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(15.1375 - lat) + Math.Abs(-23.53083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(16.75524 - lat) + Math.Abs(-22.9446 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Nova Sintra", "02", 14.87139, -24.69556);
case 1: return new CityInfo("Vila do Maio", "04", 15.13823, -23.21158);
case 2: return new CityInfo("Ribeira Brava", "22", 16.61583, -24.29833);
case 3: return new CityInfo("Tarrafal de São Nicolau", "27", 16.56622, -24.35793);
case 4: return new CityInfo("Tarrafal", "20", 15.27881, -23.75192);
case 5: return new CityInfo("São Filipe", "18", 14.8961, -24.49556);
case 6: return new CityInfo("São Domingos", "17", 15.02438, -23.5625);
case 7: return new CityInfo("Santa Maria", "08", 16.59796, -22.90509);
case 8: return new CityInfo("Santa Cruz", "16", 15.13333, -23.56667);
case 9: return new CityInfo("Sal Rei", "01", 16.17611, -22.91722);
case 10: return new CityInfo("Ribeira Grande", "07", 17.1825, -25.065);
case 11: return new CityInfo("Praia", "14", 14.93152, -23.51254);
case 12: return new CityInfo("Porto Novo", "21", 17.01969, -25.06471);
case 13: return new CityInfo("Igreja", "13", 15.03389, -24.325);
case 14: return new CityInfo("Ponta do Sol", "07", 17.20171, -25.09217);
case 15: return new CityInfo("Pombas", "05", 17.15026, -25.02007);
case 16: return new CityInfo("Picos", "26", 15.0836, -23.63236);
case 17: return new CityInfo("Mindelo", "11", 16.89014, -24.98042);
case 18: return new CityInfo("Cova Figueira", "24", 14.89054, -24.29343);
case 19: return new CityInfo("Cidade Velha", "23", 14.91531, -23.60527);
case 20: return new CityInfo("Calheta", "19", 15.18613, -23.59228);
case 21: return new CityInfo("Assomada", "15", 15.1, -23.68333);
case 22: return new CityInfo("João Teves", "25", 15.06694, -23.58917);
case 23: return new CityInfo("Pedra Badejo", "16", 15.1375, -23.53083);
default: return new CityInfo("Espargos", "08", 16.75524, -22.9446);

                                    }                                        
                                }
                            
                        }
                    }
                