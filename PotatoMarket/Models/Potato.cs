﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PotatoMarket.Models
{
	public class Potato
	{
		public enum E_Countries
		{
			Afghanistan,
			Albania,
			Algeria,
			Andorra,
			Angola,
			AntiguaAndDeps,
			Argentina,
			Armenia,
			Australia,
			Austria,
			Azerbaijan,
			Bahamas,
			Bahrain,
			Bangladesh,
			Barbados,
			Belarus,
			Belgium,
			Belize,
			Benin,
			Bhutan,
			Bolivia,
			BosniaHerzegovina,
			Botswana,
			Brazil,
			Brunei,
			Bulgaria,
			Burkina,
			Burundi,
			Cambodia,
			Cameroon,
			Canada,
			CapeVerde,
			CentralAfricanRep,
			Chad,
			Chile,
			China,
			Colombia,
			Comoros,
			Congo,
			CostaRica,
			Croatia,
			Cuba,
			Cyprus,
			CzechRepublic,
			Denmark,
			Djibouti,
			Dominica,
			DominicanRepublic,
			EastTimor,
			Ecuador,
			Egypt,
			ElSalvador,
			EquatorialGuinea,
			Eritrea,
			Estonia,
			Ethiopia,
			Fiji,
			Finland,
			France,
			Gabon,
			Gambia,
			Georgia,
			Germany,
			Ghana,
			Greece,
			Grenada,
			Guatemala,
			Guinea,
			GuineaBissau,
			Guyana,
			Haiti,
			Honduras,
			Hungary,
			Iceland,
			India,
			Indonesia,
			Iran,
			Iraq,
			Ireland,
			Israel,
			Italy,
			IvoryCoast,
			Jamaica,
			Japan,
			Jordan,
			Kazakhstan,
			Kenya,
			Kiribati,
			KoreaNorth,
			KoreaSouth,
			Kosovo,
			Kuwait,
			Kyrgyzstan,
			Laos,
			Latvia,
			Lebanon,
			Lesotho,
			Liberia,
			Libya,
			Liechtenstein,
			Lithuania,
			Luxembourg,
			Macedonia,
			Madagascar,
			Malawi,
			Malaysia,
			Maldives,
			Mali,
			Malta,
			MarshallIslands,
			Mauritania,
			Mauritius,
			Mexico,
			Micronesia,
			Moldova,
			Monaco,
			Mongolia,
			Montenegro,
			Morocco,
			Mozambique,
			Myanmar,
			Namibia,
			Nauru,
			Nepal,
			Netherlands,
			NewZealand,
			Nicaragua,
			Niger,
			Nigeria,
			Norway,
			Oman,
			Pakistan,
			Palau,
			Panama,
			PapuaNewGuinea,
			Paraguay,
			Peru,
			Philippines,
			Poland,
			Portugal,
			Qatar,
			Romania,
			RussianFederation,
			Rwanda,
			StKittsAndNevis,
			StLucia,
			SaintVincentAndtheGrenadines,
			Samoa,
			SanMarino,
			SaoTomeAndPrincipe,
			SaudiArabia,
			Senegal,
			Serbia,
			Seychelles,
			SierraLeone,
			Singapore,
			Slovakia,
			Slovenia,
			SolomonIslands,
			Somalia,
			SouthAfrica,
			SouthSudan,
			Spain,
			SriLanka,
			Sudan,
			Suriname,
			Swaziland,
			Sweden,
			Switzerland,
			Syria,
			Taiwan,
			Tajikistan,
			Tanzania,
			Thailand,
			Togo,
			Tonga,
			TrinidadAndTobago,
			Tunisia,
			Turkey,
			Turkmenistan,
			Tuvalu,
			Uganda,
			Ukraine,
			UnitedArabEmirates,
			UnitedKingdom,
			UnitedStates,
			Uruguay,
			Uzbekistan,
			Vanuatu,
			VaticanCity,
			Venezuela,
			Vietnam,
			Yemen,
			Zambia,
			Zimbabwe
		}
		public static string[] S_Countries =
		{
			"Афганистан",
			"Албания",
			"Алжир",
			"Андорра",
			"Ангола",
			"Антигуа И Депс",
			"Аргентина",
			"Армения",
			"Австралия",
			"Австрия",
			"Азербайджан",
			"Багамские острова",
			"Бахрейн",
			"Бангладеш",
			"Барбадос",
			"Беларусь",
			"Бельгия",
			"Белиз",
			"Бенин",
			"Бутан",
			"Боливия",
			"Босния-Герцеговина",
			"Ботсвана",
			"Бразилия",
			"Бруней",
			"Болгария",
			"Буркина-Фасо",
			"Бурунди",
			"Камбоджа",
			"Камерун",
			"Канада",
			"зеленый мыс",
			"Представитель Центральной Африки",
			"Чад",
			"Чили",
			"Китай",
			"Колумбия",
			"Коморские острова",
			"Конго",
			"Конго",
			"Коста Рика",
			"Хорватия",
			"Куба",
			"Кипр",
			"Чешская Республика",
			"Дания",
			"Джибути",
			"Доминика",
			"Доминиканская Республика",
			"восточный Тимор",
			"Эквадор",
			"Египет",
			"Сальвадор",
			"Экваториальная Гвинея",
			"Эритрея",
			"Эстония",
			"Эфиопия",
			"Фиджи",
			"Финляндия",
			"Франция",
			"Габон",
			"Гамбия",
			"Грузия",
			"Германия",
			"Гана",
			"Греция",
			"Гренада",
			"Гватемала",
			"Гвинея",
			"Гвинея Бисау",
			"Гайана",
			"Гаити",
			"Гондурас",
			"Венгрия",
			"Исландия",
			"Индия",
			"Индонезия",
			"Иран",
			"Ирак",
			"Ирландия",
			"Израиль",
			"Италия",
			"берег слоновой кости",
			"Ямайка",
			"Япония",
			"Иордания",
			"Казахстан",
			"Кения",
			"Кирибати",
			"Северная Корея",
			"Южная Корея",
			"Косово",
			"Кувейт",
			"Кыргызстан",
			"Лаос",
			"Латвия",
			"Ливан",
			"Лесото",
			"Либерия",
			"Ливия",
			"Лихтенштейн",
			"Литва",
			"Люксембург",
			"Македония",
			"Мадагаскар",
			"Малави",
			"Малайзия",
			"Мальдивы",
			"Мали",
			"Мальта",
			"Маршалловы острова",
			"Мавритания",
			"Маврикий",
			"Мексика",
			"Микронезия",
			"Молдова",
			"Монако",
			"Монголия",
			"Черногория",
			"Марокко",
			"Мозамбик",
			"Мьянма",
			"Намибия",
			"Науру",
			"Непал",
			"Нидерланды",
			"Новая Зеландия",
			"Никарагуа",
			"Нигер",
			"Нигерия",
			"Норвегия",
			"Оман",
			"Пакистан",
			"Палау",
			"Панама",
			"Папуа новая Гвинея",
			"Парагвай",
			"Перу",
			"Филиппины",
			"Польша",
			"Португалия",
			"Катар",
			"Румыния",
			"Российская Федерация",
			"Руанда",
			"Сент-Китс И Невис",
			"Сент-Люсия",
			"Сент-Винсент и Гренадины",
			"Самоа",
			"Сан Марино",
			"Сан-Томе И Принсипи",
			"Саудовская Аравия",
			"Сенегал",
			"Сербия",
			"Сейшельские острова",
			"Сьерра Леоне",
			"Сингапур",
			"Словакия",
			"Словения",
			"Соломоновы острова",
			"Сомали",
			"Южная Африка",
			"Южный Судан",
			"Испания",
			"ШриЛанка",
			"Судан",
			"Суринам",
			"Свазиленд",
			"Швеция",
			"Швейцария",
			"Сирия",
			"Тайвань",
			"Таджикистан",
			"Танзания",
			"Таиланд",
			"Того",
			"Тонга",
			"Тринидад И Тобаго",
			"Тунис",
			"Индейка",
			"Туркменистан",
			"Тувалу",
			"Уганда",
			"Украина",
			"объединенные арабские Эмираты",
			"Объединенное Королевство",
			"Соединенные Штаты",
			"Уругвай",
			"Узбекистан",
			"Вануату",
			"Ватикан",
			"Венесуэла",
			"Вьетнам",
			"Йемен",
			"Замбия",
			"Зимбабве"
		};
		[Key]
		public int Id { get; set; }
		[Required,MaxLength(128)]
		public string Name { get; set; }
		[Required,JsonIgnore]
		public virtual TypeOfPotato Type { get; set; }
		[Required]
		public E_Countries Country { get; set; }
		[Required]
		public int AmountKg { get; set; }
		[Required]
		public DateTime DateOfDeliveries { get; set; }

	}
}
