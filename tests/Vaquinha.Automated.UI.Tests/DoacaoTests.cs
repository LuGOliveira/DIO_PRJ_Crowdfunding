using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Vaquinha.Tests.Common.Fixtures;
using Xunit;

namespace Vaquinha.AutomatedUITests
{
	public class DoacaoTests : IDisposable, IClassFixture<DoacaoFixture>, 
                                               IClassFixture<EnderecoFixture>, 
                                               IClassFixture<CartaoCreditoFixture>
	{
		private DriverFactory _driverFactory = new DriverFactory();
		private IWebDriver _driver;

		private readonly DoacaoFixture _doacaoFixture;
		private readonly EnderecoFixture _enderecoFixture;
		private readonly CartaoCreditoFixture _cartaoCreditoFixture;

		public DoacaoTests(DoacaoFixture doacaoFixture, EnderecoFixture enderecoFixture, CartaoCreditoFixture cartaoCreditoFixture)
        {
            _doacaoFixture = doacaoFixture;
            _enderecoFixture = enderecoFixture;
            _cartaoCreditoFixture = cartaoCreditoFixture;
        }
		public void Dispose()
		{
			_driverFactory.Close();
		}

		[Fact]
		public void DoacaoUI_AcessoTelaHome()
		{
			// Arrange
			_driverFactory.NavigateToUrl("https://vaquinha.azurewebsites.net/");
			
			_driver = _driverFactory.GetWebDriver();

			// Act
			IWebElement webElement = null;
			webElement = _driver.FindElement(By.ClassName("vaquinha-logo"));

			// Assert
			webElement.Displayed.Should().BeTrue(because:"logo exibido");
		}
		[Fact]
		public void DoacaoUI_CriacaoDoacao()
		{
			//Arrange
			var doacao = _doacaoFixture.DoacaoValida();
            doacao.AdicionarEnderecoCobranca(_enderecoFixture.EnderecoValido());
            doacao.AdicionarFormaPagamento(_cartaoCreditoFixture.CartaoCreditoValido());
			_driverFactory.NavigateToUrl("https://vaquinha.azurewebsites.net/");
			_driver = _driverFactory.GetWebDriver();

			//Act
			IWebElement webElement = null;
			webElement = _driver.FindElement(By.ClassName("btn-yellow"));
			webElement.Click();

			
			IWebElement campoNome = _driver.FindElement(By.Id("DadosPessoais_Nome"));
			campoNome.SendKeys(doacao.DadosPessoais.Nome);

			IWebElement campoEmail = _driver.FindElement(By.Id("DadosPessoais_Email"));
			campoEmail.SendKeys(doacao.DadosPessoais.Email);

			IWebElement campoMensagemApoio = _driver.FindElement(By.Id("DadosPessoais_MensagemApoio"));
			campoMensagemApoio.SendKeys(doacao.DadosPessoais.MensagemApoio);

			IWebElement campoAnonima = _driver.FindElement(By.Id("DadosPessoais_Anonima"));
			campoAnonima.SendKeys(doacao.DadosPessoais.Anonima.ToString());

			IWebElement campoTextoEndereco = _driver.FindElement(By.Id("EnderecoCobranca_TextoEndereco"));
			campoTextoEndereco.SendKeys(doacao.EnderecoCobranca.TextoEndereco);

			IWebElement campoEndCobrancaNumero = _driver.FindElement(By.Id("EnderecoCobranca_Numero"));
			campoEndCobrancaNumero.SendKeys(doacao.EnderecoCobranca.Numero);

			IWebElement campoEndCobrancaCidade = _driver.FindElement(By.Id("EnderecoCobranca_Cidade"));
			campoEndCobrancaCidade.SendKeys(doacao.EnderecoCobranca.Cidade);

			IWebElement campoEstado = _driver.FindElement(By.Id("estado"));
			campoEstado.SendKeys(doacao.EnderecoCobranca.Estado);

			IWebElement campoCEP = _driver.FindElement(By.Id("cep"));
			campoCEP.SendKeys(doacao.EnderecoCobranca.CEP);

			IWebElement campoEndCobrancaComplemento = _driver.FindElement(By.Id("EnderecoCobranca_Complemento"));
			campoEndCobrancaComplemento.SendKeys(doacao.EnderecoCobranca.Complemento);

			IWebElement campoTelefone = _driver.FindElement(By.Id("telefone"));
			campoTelefone.SendKeys(doacao.EnderecoCobranca.Telefone);

			IWebElement campoTitular = _driver.FindElement(By.Id("FormaPagamento_NomeTitular"));
			campoTitular.SendKeys(doacao.FormaPagamento.NomeTitular);

			IWebElement campoNumber = _driver.FindElement(By.Id("cardNumber"));
			campoNumber.SendKeys(doacao.FormaPagamento.NumeroCartaoCredito);

			IWebElement campoValidade = _driver.FindElement(By.Id("validade"));
			campoValidade.SendKeys(doacao.FormaPagamento.Validade);

			IWebElement campoCVV = _driver.FindElement(By.Id("cvv"));
			campoCVV.SendKeys(doacao.FormaPagamento.CVV);

	
			 
			//Assert
			_driver.Url.Should().Contain("/Doacoes/Create");
		}
	}
}