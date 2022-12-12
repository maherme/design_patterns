using System;

namespace Proxy{

    // CProxy uses nested classes, with nesting the private classes are only known by CProxy
    public class CProxy{

        public interface ISubject{
            void Request(int pOption);
        }

        public class CSimpleProxy:ISubject{
            private CSubject subject;

            public void Request(int pOption){
                if(subject == null){
                    Console.WriteLine("Activating Subject");
                    subject = new CSubject();
                }
                if(pOption == 1){
                    subject.SecretInfo();
                }
                if(pOption == 2){
                    subject.PublishInfo("Hello from simple proxy");
                }
            }
        }

        public class CSecureProxy:ISubject{
            private CSubject subject;

            public void Request(int pOption){
                string password;
                Console.WriteLine("Enter Password:");
                password = Console.ReadLine();

                if(password == "123"){
                    if(subject == null){
                        Console.WriteLine("Activating Subject");
                        subject = new CSubject();
                    }
                    if(pOption == 1){
                        subject.SecretInfo();
                    }
                    if(pOption == 2){
                        subject.PublishInfo("Hello from secure proxy");
                    }
                }
                else{
                    Console.WriteLine("Access Denied");
                }
            }
        }

        // This is the class protected by the proxy:
        private class CSubject{

            public void SecretInfo(){
                Console.WriteLine("******Secret Info******");
                Console.WriteLine("bla bla bla bla bla bla");
                Console.WriteLine("ble ble ble ble ble ble");
                Console.WriteLine("bli bli bli bli bli bli");
            }

            public void PublishInfo(string pInfo){
                Console.WriteLine("Publish Info: {0}", pInfo);
            }
        }
    }
}
