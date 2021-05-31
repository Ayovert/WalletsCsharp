using System;
using WalletsAfrica.Infrastructure;
using WalletsAfrica.Services;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            IWalletsAfricaClient client = new WalletsAfricaClient("hfucj5jatq8h", "uvjqzm5xl6bw", false);

            IWalletsAfricaClientx clientx = new WalletsAfricaClientx("hfucj5jatq8h", "uvjqzm5xl6bw", false);


            SelfService selfService = new SelfService(client);

            WalletService walletService = new WalletService(client);

            PayoutService payoutService = new PayoutService(client);

            AirtimeService airtimeService = new AirtimeService(client);

            CardService cardService = new CardService(client);

            CardServicex cardServicex = new CardServicex(clientx);



            try
            {
                /*var balance = selfService.GetBalanceAsync("NGN").Result;
                Console.WriteLine($"{balance.Data.WalletCurrency} {balance.Data.WalletBalance}");

               var transactions = selfService.GetMainTransactionAsync(0, 5, "2021-02-15", "2021-05-21", 1, "NGN").Result;

               var verifyBvn = selfService.VerifyBVNAsync("222331485915", "14-04-1992").Result;

               var getWallet = selfService.GetWalletsAsync(2, 10).Result;*/

                // var debitWallet = walletService.DebitWalletAsync("test0024", 100, "08023634895").Result;

                // var creditWallet = walletService.CreditWalletAsync("test0025", 100, "08023634895").Result;

                // var generateWallet = walletService.GenerateWalletAsync("Steve", "Rogers", "captainamerica@avengers.com", "1989-03-21", "NGN").Result;

                // var retrieveAccount = walletService.RetrieveAccountAsync("2348148657415").Result;

                //var setPassword= walletService.SetPasswordAsync("13990205533", "p1ert0tuml0c0m0t0r").Result;

                // var setPin = walletService.SetPinAsync("13990205533", "0799").Result;

                //  var subTransactions = walletService.SubTransactionAsync(0, 5, "2021-03-15", "2021-04-21", 1, "08057998539", "1111", "NGN").Result;

                //  var verifySubBvn = walletService.VerifyBvnWalletAsync("22231485915", "08057998539", "14-04-1992").Result;

                // var getUserByPhone = walletService.GetUserByPhoneAsync("2344047658848").Result;

                //var getUserByEmail = walletService.GetUserByEmailAsync("Sadiqumar742@gmail.com").Result;

                //var getSubBalance = walletService.GetSubBalanceAsync("2344049658848", "NGN").Result;


                //  var getTransferDetails = payoutService.TransferDetailsAsync("test0010").Result;


                //var bankTransfer = payoutService.BankTransferAsync("058", "0116477747", "Eduvie Agada", "test0010", 20, "Test").Result;

                //var accountEnquiry = payoutService.AccountEnquiryAsync("058", "0200556677").Result;

                //  var getBanks = payoutService.GetBanksAsync().Result;

                //var airtimeProvider = airtimeService.AirtimeProviderAsync().Result;

                //var airtimePurchase = airtimeService.AirtimePurchaseAsync("mtn", 100, "07068260000").Result;

                // var nigerianStates = cardServicex.NigerianStatesAsync().Result;

                // var identityTypes = cardServicex.IdentityTypesAsync().Result;

                //var exchangeRates = cardServicex.ExchangeRatesAsync().Result;

                // var createCard = cardService.CreateCardAsync(20, "Danger", "Dave", "dangerdave@top.com", "Dave", "1967-07-18", "0029", 1 , "NGN", true, "Miami", 2, 2, "09093780201").Result;
                //  var freezeCard = cardService.FreezeCardAsync("22").Result;
                //var unFreezeCard = cardService.UnFreezeCardAsync("22").Result;

                // var fundCard = cardService.FundCardAsync("22", 10).Result;

                //var debitCard = cardService.DebitCardAsync("22", 10).Result;

                //var cardDetails = cardService.CardDetailsAsync("22").Result;

                //var cardTransactions = cardService.CardTransactionsAsync("22").Result;

                var changePin = cardService.ChangePinAsync("22", "1234").Result;


                









                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                Console.ReadKey();
            }
        }
    }
}
