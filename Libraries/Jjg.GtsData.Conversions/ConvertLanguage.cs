﻿namespace Jjg.GtsData.Conversions
{
	public class ConvertLanguage
	{
		public void Convert()
		{
//			return e.defineLocale('af', {
//		  months: 'Januarie_Februarie_Maart_April_Mei_Junie_Julie_Augustus_September_Oktober_November_Desember'.split('_'),
//		  monthsShort: 'Jan_Feb_Mrt_Apr_Mei_Jun_Jul_Aug_Sep_Okt_Nov_Des'.split('_'),
//		  weekdays: 'Sondag_Maandag_Dinsdag_Woensdag_Donderdag_Vrydag_Saterdag'.split('_'),
//		  weekdaysShort: 'Son_Maa_Din_Woe_Don_Vry_Sat'.split('_'),
//		  weekdaysMin: 'So_Ma_Di_Wo_Do_Vr_Sa'.split('_'),
//		  meridiemParse: /vm|nm/i,
//		  isPM: function (e) {
//			return /^nm$/i.test(e)
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? n ? 'vm' : 'VM' : n ? 'nm' : 'NM'
//		  },
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Vandag om] LT',
//			nextDay: '[Môre om] LT',
//			nextWeek: 'dddd [om] LT',
//			lastDay: '[Gister om] LT',
//			lastWeek: '[Laas] dddd [om] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'oor %s',
//			past: '%s gelede',
//			s: '\'n paar sekondes',
//			ss: '%d sekondes',
//			m: '\'n minuut',
//			mm: '%d minute',
//			h: '\'n uur',
//			hh: '%d ure',
//			d: '\'n dag',
//			dd: '%d dae',
//			M: '\'n maand',
//			MM: '%d maande',
//			y: '\'n jaar',
//			yy: '%d jaar'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(ste|de)/,
//		  ordinal: function (e) {
//			return e + (1 === e || 8 === e || e >= 20 ? 'ste' : 'de')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '١',
//		  2: '٢',
//		  3: '٣',
//		  4: '٤',
//		  5: '٥',
//		  6: '٦',
//		  7: '٧',
//		  8: '٨',
//		  9: '٩',
//		  0: '٠'
//		},
//		n = {
//		  '١': '1',
//		  '٢': '2',
//		  '٣': '3',
//		  '٤': '4',
//		  '٥': '5',
//		  '٦': '6',
//		  '٧': '7',
//		  '٨': '8',
//		  '٩': '9',
//		  '٠': '0'
//		},
//		r = function (e) {
//		  return 0 === e ? 0 : 1 === e ? 1 : 2 === e ? 2 : e % 100 >= 3 && e % 100 <= 10 ? 3 : e % 100 >= 11 ? 4 : 5
//		},
//		a = {
//		  s: [
//			'أقل من ثانية',
//			'ثانية واحدة',
//			[
//			  'ثانيتان',
//			  'ثانيتين'
//			],
//			'%d ثوان',
//			'%d ثانية',
//			'%d ثانية'
//		  ],
//		  m: [
//			'أقل من دقيقة',
//			'دقيقة واحدة',
//			[
//			  'دقيقتان',
//			  'دقيقتين'
//			],
//			'%d دقائق',
//			'%d دقيقة',
//			'%d دقيقة'
//		  ],
//		  h: [
//			'أقل من ساعة',
//			'ساعة واحدة',
//			[
//			  'ساعتان',
//			  'ساعتين'
//			],
//			'%d ساعات',
//			'%d ساعة',
//			'%d ساعة'
//		  ],
//		  d: [
//			'أقل من يوم',
//			'يوم واحد',
//			[
//			  'يومان',
//			  'يومين'
//			],
//			'%d أيام',
//			'%d يومًا',
//			'%d يوم'
//		  ],
//		  M: [
//			'أقل من شهر',
//			'شهر واحد',
//			[
//			  'شهران',
//			  'شهرين'
//			],
//			'%d أشهر',
//			'%d شهرا',
//			'%d شهر'
//		  ],
//		  y: [
//			'أقل من عام',
//			'عام واحد',
//			[
//			  'عامان',
//			  'عامين'
//			],
//			'%d أعوام',
//			'%d عامًا',
//			'%d عام'
//		  ]
//		},
//		o = function (e) {
//		  return function (t, n, o, i) {
//			var s = r(t),
//			u = a[e][r(t)];
//			return 2 === s && (u = u[n ? 0 : 1]),
//			u.replace(/%d/i, t)
//		  }
//		},
//		i = [
//		  'يناير',
//		  'فبراير',
//		  'مارس',
//		  'أبريل',
//		  'مايو',
//		  'يونيو',
//		  'يوليو',
//		  'أغسطس',
//		  'سبتمبر',
//		  'أكتوبر',
//		  'نوفمبر',
//		  'ديسمبر'
//		];
//		return e.defineLocale('ar', {
//		  months: i,
//		  monthsShort: i,
//		  weekdays: 'الأحد_الإثنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'أحد_إثنين_ثلاثاء_أربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'D/‏M/‏YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /ص|م/,
//		  isPM: function (e) {
//			return 'م' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'ص' : 'م'
//		  },
//		  calendar: {
//			sameDay: '[اليوم عند الساعة] LT',
//			nextDay: '[غدًا عند الساعة] LT',
//			nextWeek: 'dddd [عند الساعة] LT',
//			lastDay: '[أمس عند الساعة] LT',
//			lastWeek: 'dddd [عند الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'بعد %s',
//			past: 'منذ %s',
//			s: o('s'),
//			ss: o('s'),
//			m: o('m'),
//			mm: o('m'),
//			h: o('h'),
//			hh: o('h'),
//			d: o('d'),
//			dd: o('d'),
//			M: o('M'),
//			MM: o('M'),
//			y: o('y'),
//			yy: o('y')
//		  },
//		  preparse: function (e) {
//			return e.replace(/[١٢٣٤٥٦٧٨٩٠]/g, function (e) {
//			  return n[e]
//			}).replace(/،/g, ',')
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			}).replace(/,/g, '،')
//		  },
//		  week: {
//			dow: 6,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ar-dz', {
//		  months: 'جانفي_فيفري_مارس_أفريل_ماي_جوان_جويلية_أوت_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  monthsShort: 'جانفي_فيفري_مارس_أفريل_ماي_جوان_جويلية_أوت_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  weekdays: 'الأحد_الإثنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'احد_اثنين_ثلاثاء_اربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'أح_إث_ثلا_أر_خم_جم_سب'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[اليوم على الساعة] LT',
//			nextDay: '[غدا على الساعة] LT',
//			nextWeek: 'dddd [على الساعة] LT',
//			lastDay: '[أمس على الساعة] LT',
//			lastWeek: 'dddd [على الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'في %s',
//			past: 'منذ %s',
//			s: 'ثوان',
//			ss: '%d ثانية',
//			m: 'دقيقة',
//			mm: '%d دقائق',
//			h: 'ساعة',
//			hh: '%d ساعات',
//			d: 'يوم',
//			dd: '%d أيام',
//			M: 'شهر',
//			MM: '%d أشهر',
//			y: 'سنة',
//			yy: '%d سنوات'
//		  },
//		  week: {
//			dow: 0,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ar-kw', {
//		  months: 'يناير_فبراير_مارس_أبريل_ماي_يونيو_يوليوز_غشت_شتنبر_أكتوبر_نونبر_دجنبر'.split('_'),
//		  monthsShort: 'يناير_فبراير_مارس_أبريل_ماي_يونيو_يوليوز_غشت_شتنبر_أكتوبر_نونبر_دجنبر'.split('_'),
//		  weekdays: 'الأحد_الإتنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'احد_اتنين_ثلاثاء_اربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[اليوم على الساعة] LT',
//			nextDay: '[غدا على الساعة] LT',
//			nextWeek: 'dddd [على الساعة] LT',
//			lastDay: '[أمس على الساعة] LT',
//			lastWeek: 'dddd [على الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'في %s',
//			past: 'منذ %s',
//			s: 'ثوان',
//			ss: '%d ثانية',
//			m: 'دقيقة',
//			mm: '%d دقائق',
//			h: 'ساعة',
//			hh: '%d ساعات',
//			d: 'يوم',
//			dd: '%d أيام',
//			M: 'شهر',
//			MM: '%d أشهر',
//			y: 'سنة',
//			yy: '%d سنوات'
//		  },
//		  week: {
//			dow: 0,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '1',
//		  2: '2',
//		  3: '3',
//		  4: '4',
//		  5: '5',
//		  6: '6',
//		  7: '7',
//		  8: '8',
//		  9: '9',
//		  0: '0'
//		},
//		n = function (e) {
//		  return 0 === e ? 0 : 1 === e ? 1 : 2 === e ? 2 : e % 100 >= 3 && e % 100 <= 10 ? 3 : e % 100 >= 11 ? 4 : 5
//		},
//		r = {
//		  s: [
//			'أقل من ثانية',
//			'ثانية واحدة',
//			[
//			  'ثانيتان',
//			  'ثانيتين'
//			],
//			'%d ثوان',
//			'%d ثانية',
//			'%d ثانية'
//		  ],
//		  m: [
//			'أقل من دقيقة',
//			'دقيقة واحدة',
//			[
//			  'دقيقتان',
//			  'دقيقتين'
//			],
//			'%d دقائق',
//			'%d دقيقة',
//			'%d دقيقة'
//		  ],
//		  h: [
//			'أقل من ساعة',
//			'ساعة واحدة',
//			[
//			  'ساعتان',
//			  'ساعتين'
//			],
//			'%d ساعات',
//			'%d ساعة',
//			'%d ساعة'
//		  ],
//		  d: [
//			'أقل من يوم',
//			'يوم واحد',
//			[
//			  'يومان',
//			  'يومين'
//			],
//			'%d أيام',
//			'%d يومًا',
//			'%d يوم'
//		  ],
//		  M: [
//			'أقل من شهر',
//			'شهر واحد',
//			[
//			  'شهران',
//			  'شهرين'
//			],
//			'%d أشهر',
//			'%d شهرا',
//			'%d شهر'
//		  ],
//		  y: [
//			'أقل من عام',
//			'عام واحد',
//			[
//			  'عامان',
//			  'عامين'
//			],
//			'%d أعوام',
//			'%d عامًا',
//			'%d عام'
//		  ]
//		},
//		a = function (e) {
//		  return function (t, a, o, i) {
//			var s = n(t),
//			u = r[e][n(t)];
//			return 2 === s && (u = u[a ? 0 : 1]),
//			u.replace(/%d/i, t)
//		  }
//		},
//		o = [
//		  'يناير',
//		  'فبراير',
//		  'مارس',
//		  'أبريل',
//		  'مايو',
//		  'يونيو',
//		  'يوليو',
//		  'أغسطس',
//		  'سبتمبر',
//		  'أكتوبر',
//		  'نوفمبر',
//		  'ديسمبر'
//		];
//		return e.defineLocale('ar-ly', {
//		  months: o,
//		  monthsShort: o,
//		  weekdays: 'الأحد_الإثنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'أحد_إثنين_ثلاثاء_أربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'D/‏M/‏YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /ص|م/,
//		  isPM: function (e) {
//			return 'م' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'ص' : 'م'
//		  },
//		  calendar: {
//			sameDay: '[اليوم عند الساعة] LT',
//			nextDay: '[غدًا عند الساعة] LT',
//			nextWeek: 'dddd [عند الساعة] LT',
//			lastDay: '[أمس عند الساعة] LT',
//			lastWeek: 'dddd [عند الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'بعد %s',
//			past: 'منذ %s',
//			s: a('s'),
//			ss: a('s'),
//			m: a('m'),
//			mm: a('m'),
//			h: a('h'),
//			hh: a('h'),
//			d: a('d'),
//			dd: a('d'),
//			M: a('M'),
//			MM: a('M'),
//			y: a('y'),
//			yy: a('y')
//		  },
//		  preparse: function (e) {
//			return e.replace(/،/g, ',')
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			}).replace(/,/g, '،')
//		  },
//		  week: {
//			dow: 6,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ar-ma', {
//		  months: 'يناير_فبراير_مارس_أبريل_ماي_يونيو_يوليوز_غشت_شتنبر_أكتوبر_نونبر_دجنبر'.split('_'),
//		  monthsShort: 'يناير_فبراير_مارس_أبريل_ماي_يونيو_يوليوز_غشت_شتنبر_أكتوبر_نونبر_دجنبر'.split('_'),
//		  weekdays: 'الأحد_الإتنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'احد_اتنين_ثلاثاء_اربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[اليوم على الساعة] LT',
//			nextDay: '[غدا على الساعة] LT',
//			nextWeek: 'dddd [على الساعة] LT',
//			lastDay: '[أمس على الساعة] LT',
//			lastWeek: 'dddd [على الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'في %s',
//			past: 'منذ %s',
//			s: 'ثوان',
//			ss: '%d ثانية',
//			m: 'دقيقة',
//			mm: '%d دقائق',
//			h: 'ساعة',
//			hh: '%d ساعات',
//			d: 'يوم',
//			dd: '%d أيام',
//			M: 'شهر',
//			MM: '%d أشهر',
//			y: 'سنة',
//			yy: '%d سنوات'
//		  },
//		  week: {
//			dow: 6,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '١',
//		  2: '٢',
//		  3: '٣',
//		  4: '٤',
//		  5: '٥',
//		  6: '٦',
//		  7: '٧',
//		  8: '٨',
//		  9: '٩',
//		  0: '٠'
//		},
//		n = {
//		  '١': '1',
//		  '٢': '2',
//		  '٣': '3',
//		  '٤': '4',
//		  '٥': '5',
//		  '٦': '6',
//		  '٧': '7',
//		  '٨': '8',
//		  '٩': '9',
//		  '٠': '0'
//		};
//		return e.defineLocale('ar-sa', {
//		  months: 'يناير_فبراير_مارس_أبريل_مايو_يونيو_يوليو_أغسطس_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  monthsShort: 'يناير_فبراير_مارس_أبريل_مايو_يونيو_يوليو_أغسطس_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  weekdays: 'الأحد_الإثنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'أحد_إثنين_ثلاثاء_أربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /ص|م/,
//		  isPM: function (e) {
//			return 'م' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'ص' : 'م'
//		  },
//		  calendar: {
//			sameDay: '[اليوم على الساعة] LT',
//			nextDay: '[غدا على الساعة] LT',
//			nextWeek: 'dddd [على الساعة] LT',
//			lastDay: '[أمس على الساعة] LT',
//			lastWeek: 'dddd [على الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'في %s',
//			past: 'منذ %s',
//			s: 'ثوان',
//			ss: '%d ثانية',
//			m: 'دقيقة',
//			mm: '%d دقائق',
//			h: 'ساعة',
//			hh: '%d ساعات',
//			d: 'يوم',
//			dd: '%d أيام',
//			M: 'شهر',
//			MM: '%d أشهر',
//			y: 'سنة',
//			yy: '%d سنوات'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[١٢٣٤٥٦٧٨٩٠]/g, function (e) {
//			  return n[e]
//			}).replace(/،/g, ',')
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			}).replace(/,/g, '،')
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ar-tn', {
//		  months: 'جانفي_فيفري_مارس_أفريل_ماي_جوان_جويلية_أوت_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  monthsShort: 'جانفي_فيفري_مارس_أفريل_ماي_جوان_جويلية_أوت_سبتمبر_أكتوبر_نوفمبر_ديسمبر'.split('_'),
//		  weekdays: 'الأحد_الإثنين_الثلاثاء_الأربعاء_الخميس_الجمعة_السبت'.split('_'),
//		  weekdaysShort: 'أحد_إثنين_ثلاثاء_أربعاء_خميس_جمعة_سبت'.split('_'),
//		  weekdaysMin: 'ح_ن_ث_ر_خ_ج_س'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[اليوم على الساعة] LT',
//			nextDay: '[غدا على الساعة] LT',
//			nextWeek: 'dddd [على الساعة] LT',
//			lastDay: '[أمس على الساعة] LT',
//			lastWeek: 'dddd [على الساعة] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'في %s',
//			past: 'منذ %s',
//			s: 'ثوان',
//			ss: '%d ثانية',
//			m: 'دقيقة',
//			mm: '%d دقائق',
//			h: 'ساعة',
//			hh: '%d ساعات',
//			d: 'يوم',
//			dd: '%d أيام',
//			M: 'شهر',
//			MM: '%d أشهر',
//			y: 'سنة',
//			yy: '%d سنوات'
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '-inci',
//		  5: '-inci',
//		  8: '-inci',
//		  70: '-inci',
//		  80: '-inci',
//		  2: '-nci',
//		  7: '-nci',
//		  20: '-nci',
//		  50: '-nci',
//		  3: '-üncü',
//		  4: '-üncü',
//		  100: '-üncü',
//		  6: '-ncı',
//		  9: '-uncu',
//		  10: '-uncu',
//		  30: '-uncu',
//		  60: '-ıncı',
//		  90: '-ıncı'
//		};
//		return e.defineLocale('az', {
//		  months: 'yanvar_fevral_mart_aprel_may_iyun_iyul_avqust_sentyabr_oktyabr_noyabr_dekabr'.split('_'),
//		  monthsShort: 'yan_fev_mar_apr_may_iyn_iyl_avq_sen_okt_noy_dek'.split('_'),
//		  weekdays: 'Bazar_Bazar ertəsi_Çərşənbə axşamı_Çərşənbə_Cümə axşamı_Cümə_Şənbə'.split('_'),
//		  weekdaysShort: 'Baz_BzE_ÇAx_Çər_CAx_Cüm_Şən'.split('_'),
//		  weekdaysMin: 'Bz_BE_ÇA_Çə_CA_Cü_Şə'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[bugün saat] LT',
//			nextDay: '[sabah saat] LT',
//			nextWeek: '[gələn həftə] dddd [saat] LT',
//			lastDay: '[dünən] LT',
//			lastWeek: '[keçən həftə] dddd [saat] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s sonra',
//			past: '%s əvvəl',
//			s: 'birneçə saniyyə',
//			ss: '%d saniyə',
//			m: 'bir dəqiqə',
//			mm: '%d dəqiqə',
//			h: 'bir saat',
//			hh: '%d saat',
//			d: 'bir gün',
//			dd: '%d gün',
//			M: 'bir ay',
//			MM: '%d ay',
//			y: 'bir il',
//			yy: '%d il'
//		  },
//		  meridiemParse: /gecə|səhər|gündüz|axşam/,
//		  isPM: function (e) {
//			return /^(gündüz|axşam)$/.test(e)
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'gecə' : e < 12 ? 'səhər' : e < 17 ? 'gündüz' : 'axşam'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(ıncı|inci|nci|üncü|ncı|uncu)/,
//		  ordinal: function (e) {
//			if (0 === e) return e + '-ıncı';
//			var n = e % 10,
//			r = e % 100 - n,
//			a = e >= 100 ? 100 : null;
//			return e + (t[n] || t[r] || t[a])
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t) {
//		  var n = e.split('_');
//		  return t % 10 == 1 && t % 100 != 11 ? n[0] : t % 10 >= 2 && t % 10 <= 4 && (t % 100 < 10 || t % 100 >= 20) ? n[1] : n[2]
//		}
//		function n(e, n, r) {
//		  var a = {
//			ss: n ? 'секунда_секунды_секунд' : 'секунду_секунды_секунд',
//			mm: n ? 'хвіліна_хвіліны_хвілін' : 'хвіліну_хвіліны_хвілін',
//			hh: n ? 'гадзіна_гадзіны_гадзін' : 'гадзіну_гадзіны_гадзін',
//			dd: 'дзень_дні_дзён',
//			MM: 'месяц_месяцы_месяцаў',
//			yy: 'год_гады_гадоў'
//		  };
//		  return 'm' === r ? n ? 'хвіліна' : 'хвіліну' : 'h' === r ? n ? 'гадзіна' : 'гадзіну' : e + ' ' + t(a[r], + e)
//		}
//		return e.defineLocale('be', {
//		  months: {
//			format: 'студзеня_лютага_сакавіка_красавіка_траўня_чэрвеня_ліпеня_жніўня_верасня_кастрычніка_лістапада_снежня'.split('_'),
//			standalone: 'студзень_люты_сакавік_красавік_травень_чэрвень_ліпень_жнівень_верасень_кастрычнік_лістапад_снежань'.split('_')
//		  },
//		  monthsShort: 'студ_лют_сак_крас_трав_чэрв_ліп_жнів_вер_каст_ліст_снеж'.split('_'),
//		  weekdays: {
//			format: 'нядзелю_панядзелак_аўторак_сераду_чацвер_пятніцу_суботу'.split('_'),
//			standalone: 'нядзеля_панядзелак_аўторак_серада_чацвер_пятніца_субота'.split('_'),
//			isFormat: /\[ ?[Вв] ?(?:мінулую|наступную)? ?\] ?dddd/
//		  },
//		  weekdaysShort: 'нд_пн_ат_ср_чц_пт_сб'.split('_'),
//		  weekdaysMin: 'нд_пн_ат_ср_чц_пт_сб'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY г.',
//			LLL: 'D MMMM YYYY г., HH:mm',
//			LLLL: 'dddd, D MMMM YYYY г., HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Сёння ў] LT',
//			nextDay: '[Заўтра ў] LT',
//			lastDay: '[Учора ў] LT',
//			nextWeek: function () {
//			  return '[У] dddd [ў] LT'
//			},
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				case 3:
//				case 5:
//				case 6:
//				  return '[У мінулую] dddd [ў] LT';
//				case 1:
//				case 2:
//				case 4:
//				  return '[У мінулы] dddd [ў] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'праз %s',
//			past: '%s таму',
//			s: 'некалькі секунд',
//			m: n,
//			mm: n,
//			h: n,
//			hh: n,
//			d: 'дзень',
//			dd: n,
//			M: 'месяц',
//			MM: n,
//			y: 'год',
//			yy: n
//		  },
//		  meridiemParse: /ночы|раніцы|дня|вечара/,
//		  isPM: function (e) {
//			return /^(дня|вечара)$/.test(e)
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'ночы' : e < 12 ? 'раніцы' : e < 17 ? 'дня' : 'вечара'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(і|ы|га)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'M':
//			  case 'd':
//			  case 'DDD':
//			  case 'w':
//			  case 'W':
//				return e % 10 != 2 && e % 10 != 3 || e % 100 == 12 || e % 100 == 13 ? e + '-ы' : e + '-і';
//			  case 'D':
//				return e + '-га';
//			  default:
//				return e
//			}
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	}, function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('bg', {
//		  months: 'януари_февруари_март_април_май_юни_юли_август_септември_октомври_ноември_декември'.split('_'),
//		  monthsShort: 'янр_фев_мар_апр_май_юни_юли_авг_сеп_окт_ное_дек'.split('_'),
//		  weekdays: 'неделя_понеделник_вторник_сряда_четвъртък_петък_събота'.split('_'),
//		  weekdaysShort: 'нед_пон_вто_сря_чет_пет_съб'.split('_'),
//		  weekdaysMin: 'нд_пн_вт_ср_чт_пт_сб'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'D.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY H:mm',
//			LLLL: 'dddd, D MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[Днес в] LT',
//			nextDay: '[Утре в] LT',
//			nextWeek: 'dddd [в] LT',
//			lastDay: '[Вчера в] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				case 3:
//				case 6:
//				  return '[В изминалата] dddd [в] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[В изминалия] dddd [в] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'след %s',
//			past: 'преди %s',
//			s: 'няколко секунди',
//			ss: '%d секунди',
//			m: 'минута',
//			mm: '%d минути',
//			h: 'час',
//			hh: '%d часа',
//			d: 'ден',
//			dd: '%d дни',
//			M: 'месец',
//			MM: '%d месеца',
//			y: 'година',
//			yy: '%d години'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(ев|ен|ти|ви|ри|ми)/,
//		  ordinal: function (e) {
//			var t = e % 10,
//			n = e % 100;
//			return 0 === e ? e + '-ев' : 0 === n ? e + '-ен' : n > 10 && n < 20 ? e + '-ти' : 1 === t ? e + '-ви' : 2 === t ? e + '-ри' : 7 === t || 8 === t ? e + '-ми' : e + '-ти'
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('bm', {
//		  months: 'Zanwuyekalo_Fewuruyekalo_Marisikalo_Awirilikalo_Mɛkalo_Zuwɛnkalo_Zuluyekalo_Utikalo_Sɛtanburukalo_ɔkutɔburukalo_Nowanburukalo_Desanburukalo'.split('_'),
//		  monthsShort: 'Zan_Few_Mar_Awi_Mɛ_Zuw_Zul_Uti_Sɛt_ɔku_Now_Des'.split('_'),
//		  weekdays: 'Kari_Ntɛnɛn_Tarata_Araba_Alamisa_Juma_Sibiri'.split('_'),
//		  weekdaysShort: 'Kar_Ntɛ_Tar_Ara_Ala_Jum_Sib'.split('_'),
//		  weekdaysMin: 'Ka_Nt_Ta_Ar_Al_Ju_Si'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'MMMM [tile] D [san] YYYY',
//			LLL: 'MMMM [tile] D [san] YYYY [lɛrɛ] HH:mm',
//			LLLL: 'dddd MMMM [tile] D [san] YYYY [lɛrɛ] HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Bi lɛrɛ] LT',
//			nextDay: '[Sini lɛrɛ] LT',
//			nextWeek: 'dddd [don lɛrɛ] LT',
//			lastDay: '[Kunu lɛrɛ] LT',
//			lastWeek: 'dddd [tɛmɛnen lɛrɛ] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s kɔnɔ',
//			past: 'a bɛ %s bɔ',
//			s: 'sanga dama dama',
//			ss: 'sekondi %d',
//			m: 'miniti kelen',
//			mm: 'miniti %d',
//			h: 'lɛrɛ kelen',
//			hh: 'lɛrɛ %d',
//			d: 'tile kelen',
//			dd: 'tile %d',
//			M: 'kalo kelen',
//			MM: 'kalo %d',
//			y: 'san kelen',
//			yy: 'san %d'
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '১',
//		  2: '২',
//		  3: '৩',
//		  4: '৪',
//		  5: '৫',
//		  6: '৬',
//		  7: '৭',
//		  8: '৮',
//		  9: '৯',
//		  0: '০'
//		},
//		n = {
//		  '১': '1',
//		  '২': '2',
//		  '৩': '3',
//		  '৪': '4',
//		  '৫': '5',
//		  '৬': '6',
//		  '৭': '7',
//		  '৮': '8',
//		  '৯': '9',
//		  '০': '0'
//		};
//		return e.defineLocale('bn', {
//		  months: 'জানুয়ারী_ফেব্রুয়ারি_মার্চ_এপ্রিল_মে_জুন_জুলাই_আগস্ট_সেপ্টেম্বর_অক্টোবর_নভেম্বর_ডিসেম্বর'.split('_'),
//		  monthsShort: 'জানু_ফেব_মার্চ_এপ্র_মে_জুন_জুল_আগ_সেপ্ট_অক্টো_নভে_ডিসে'.split('_'),
//		  weekdays: 'রবিবার_সোমবার_মঙ্গলবার_বুধবার_বৃহস্পতিবার_শুক্রবার_শনিবার'.split('_'),
//		  weekdaysShort: 'রবি_সোম_মঙ্গল_বুধ_বৃহস্পতি_শুক্র_শনি'.split('_'),
//		  weekdaysMin: 'রবি_সোম_মঙ্গ_বুধ_বৃহঃ_শুক্র_শনি'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm সময়',
//			LTS: 'A h:mm:ss সময়',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm সময়',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm সময়'
//		  },
//		  calendar: {
//			sameDay: '[আজ] LT',
//			nextDay: '[আগামীকাল] LT',
//			nextWeek: 'dddd, LT',
//			lastDay: '[গতকাল] LT',
//			lastWeek: '[গত] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s পরে',
//			past: '%s আগে',
//			s: 'কয়েক সেকেন্ড',
//			ss: '%d সেকেন্ড',
//			m: 'এক মিনিট',
//			mm: '%d মিনিট',
//			h: 'এক ঘন্টা',
//			hh: '%d ঘন্টা',
//			d: 'এক দিন',
//			dd: '%d দিন',
//			M: 'এক মাস',
//			MM: '%d মাস',
//			y: 'এক বছর',
//			yy: '%d বছর'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[১২৩৪৫৬৭৮৯০]/g, function (e) {
//			  return n[e]
//			})
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			})
//		  },
//		  meridiemParse: /রাত|সকাল|দুপুর|বিকাল|রাত/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'রাত' === t && e >= 4 || 'দুপুর' === t && e < 5 || 'বিকাল' === t ? e + 12 : e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'রাত' : e < 10 ? 'সকাল' : e < 17 ? 'দুপুর' : e < 20 ? 'বিকাল' : 'রাত'
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '༡',
//		  2: '༢',
//		  3: '༣',
//		  4: '༤',
//		  5: '༥',
//		  6: '༦',
//		  7: '༧',
//		  8: '༨',
//		  9: '༩',
//		  0: '༠'
//		},
//		n = {
//		  '༡': '1',
//		  '༢': '2',
//		  '༣': '3',
//		  '༤': '4',
//		  '༥': '5',
//		  '༦': '6',
//		  '༧': '7',
//		  '༨': '8',
//		  '༩': '9',
//		  '༠': '0'
//		};
//		return e.defineLocale('bo', {
//		  months: 'ཟླ་བ་དང་པོ_ཟླ་བ་གཉིས་པ_ཟླ་བ་གསུམ་པ_ཟླ་བ་བཞི་པ_ཟླ་བ་ལྔ་པ_ཟླ་བ་དྲུག་པ_ཟླ་བ་བདུན་པ_ཟླ་བ་བརྒྱད་པ_ཟླ་བ་དགུ་པ_ཟླ་བ་བཅུ་པ_ཟླ་བ་བཅུ་གཅིག་པ_ཟླ་བ་བཅུ་གཉིས་པ'.split('_'),
//		  monthsShort: 'ཟླ་བ་དང་པོ_ཟླ་བ་གཉིས་པ_ཟླ་བ་གསུམ་པ_ཟླ་བ་བཞི་པ_ཟླ་བ་ལྔ་པ_ཟླ་བ་དྲུག་པ_ཟླ་བ་བདུན་པ_ཟླ་བ་བརྒྱད་པ_ཟླ་བ་དགུ་པ_ཟླ་བ་བཅུ་པ_ཟླ་བ་བཅུ་གཅིག་པ_ཟླ་བ་བཅུ་གཉིས་པ'.split('_'),
//		  weekdays: 'གཟའ་ཉི་མ་_གཟའ་ཟླ་བ་_གཟའ་མིག་དམར་_གཟའ་ལྷག་པ་_གཟའ་ཕུར་བུ_གཟའ་པ་སངས་_གཟའ་སྤེན་པ་'.split('_'),
//		  weekdaysShort: 'ཉི་མ་_ཟླ་བ་_མིག་དམར་_ལྷག་པ་_ཕུར་བུ_པ་སངས་_སྤེན་པ་'.split('_'),
//		  weekdaysMin: 'ཉི་མ་_ཟླ་བ་_མིག་དམར་_ལྷག་པ་_ཕུར་བུ_པ་སངས་_སྤེན་པ་'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm',
//			LTS: 'A h:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm'
//		  },
//		  calendar: {
//			sameDay: '[དི་རིང] LT',
//			nextDay: '[སང་ཉིན] LT',
//			nextWeek: '[བདུན་ཕྲག་རྗེས་མ], LT',
//			lastDay: '[ཁ་སང] LT',
//			lastWeek: '[བདུན་ཕྲག་མཐའ་མ] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s ལ་',
//			past: '%s སྔན་ལ',
//			s: 'ལམ་སང',
//			ss: '%d སྐར་ཆ།',
//			m: 'སྐར་མ་གཅིག',
//			mm: '%d སྐར་མ',
//			h: 'ཆུ་ཚོད་གཅིག',
//			hh: '%d ཆུ་ཚོད',
//			d: 'ཉིན་གཅིག',
//			dd: '%d ཉིན་',
//			M: 'ཟླ་བ་གཅིག',
//			MM: '%d ཟླ་བ',
//			y: 'ལོ་གཅིག',
//			yy: '%d ལོ'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[༡༢༣༤༥༦༧༨༩༠]/g, function (e) {
//			  return n[e]
//			})
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			})
//		  },
//		  meridiemParse: /མཚན་མོ|ཞོགས་ཀས|ཉིན་གུང|དགོང་དག|མཚན་མོ/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'མཚན་མོ' === t && e >= 4 || 'ཉིན་གུང' === t && e < 5 || 'དགོང་དག' === t ? e + 12 : e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'མཚན་མོ' : e < 10 ? 'ཞོགས་ཀས' : e < 17 ? 'ཉིན་གུང' : e < 20 ? 'དགོང་དག' : 'མཚན་མོ'
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n) {
//		  return e + ' ' + a({
//			mm: 'munutenn',
//			MM: 'miz',
//			dd: 'devezh'
//		  }
//		  [
//			n
//		  ], e)
//		}
//		function n(e) {
//		  switch (r(e)) {
//			case 1:
//			case 3:
//			case 4:
//			case 5:
//			case 9:
//			  return e + ' bloaz';
//			default:
//			  return e + ' vloaz'
//		  }
//		}
//		function r(e) {
//		  return e > 9 ? r(e % 10)  : e
//		}
//		function a(e, t) {
//		  return 2 === t ? o(e)  : e
//		}
//		function o(e) {
//		  var t = {
//			m: 'v',
//			b: 'v',
//			d: 'z'
//		  };
//		  return void 0 === t[e.charAt(0)] ? e : t[e.charAt(0)] + e.substring(1)
//		}
//		return e.defineLocale('br', {
//		  months: 'Genver_C\'hwevrer_Meurzh_Ebrel_Mae_Mezheven_Gouere_Eost_Gwengolo_Here_Du_Kerzu'.split('_'),
//		  monthsShort: 'Gen_C\'hwe_Meu_Ebr_Mae_Eve_Gou_Eos_Gwe_Her_Du_Ker'.split('_'),
//		  weekdays: 'Sul_Lun_Meurzh_Merc\'her_Yaou_Gwener_Sadorn'.split('_'),
//		  weekdaysShort: 'Sul_Lun_Meu_Mer_Yao_Gwe_Sad'.split('_'),
//		  weekdaysMin: 'Su_Lu_Me_Mer_Ya_Gw_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'h[e]mm A',
//			LTS: 'h[e]mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D [a viz] MMMM YYYY',
//			LLL: 'D [a viz] MMMM YYYY h[e]mm A',
//			LLLL: 'dddd, D [a viz] MMMM YYYY h[e]mm A'
//		  },
//		  calendar: {
//			sameDay: '[Hiziv da] LT',
//			nextDay: '[Warc\'hoazh da] LT',
//			nextWeek: 'dddd [da] LT',
//			lastDay: '[Dec\'h da] LT',
//			lastWeek: 'dddd [paset da] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'a-benn %s',
//			past: '%s \'zo',
//			s: 'un nebeud segondennoù',
//			ss: '%d eilenn',
//			m: 'ur vunutenn',
//			mm: t,
//			h: 'un eur',
//			hh: '%d eur',
//			d: 'un devezh',
//			dd: t,
//			M: 'ur miz',
//			MM: t,
//			y: 'ur bloaz',
//			yy: n
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(añ|vet)/,
//		  ordinal: function (e) {
//			return e + (1 === e ? 'añ' : 'vet')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n) {
//		  var r = e + ' ';
//		  switch (n) {
//			case 'ss':
//			  return r += 1 === e ? 'sekunda' : 2 === e || 3 === e || 4 === e ? 'sekunde' : 'sekundi';
//			case 'm':
//			  return t ? 'jedna minuta' : 'jedne minute';
//			case 'mm':
//			  return r += 1 === e ? 'minuta' : 2 === e || 3 === e || 4 === e ? 'minute' : 'minuta';
//			case 'h':
//			  return t ? 'jedan sat' : 'jednog sata';
//			case 'hh':
//			  return r += 1 === e ? 'sat' : 2 === e || 3 === e || 4 === e ? 'sata' : 'sati';
//			case 'dd':
//			  return r += 1 === e ? 'dan' : 'dana';
//			case 'MM':
//			  return r += 1 === e ? 'mjesec' : 2 === e || 3 === e || 4 === e ? 'mjeseca' : 'mjeseci';
//			case 'yy':
//			  return r += 1 === e ? 'godina' : 2 === e || 3 === e || 4 === e ? 'godine' : 'godina'
//		  }
//		}
//		return e.defineLocale('bs', {
//		  months: 'januar_februar_mart_april_maj_juni_juli_august_septembar_oktobar_novembar_decembar'.split('_'),
//		  monthsShort: 'jan._feb._mar._apr._maj._jun._jul._aug._sep._okt._nov._dec.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'nedjelja_ponedjeljak_utorak_srijeda_četvrtak_petak_subota'.split('_'),
//		  weekdaysShort: 'ned._pon._uto._sri._čet._pet._sub.'.split('_'),
//		  weekdaysMin: 'ne_po_ut_sr_če_pe_su'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm',
//			LLLL: 'dddd, D. MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[danas u] LT',
//			nextDay: '[sutra u] LT',
//			nextWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[u] [nedjelju] [u] LT';
//				case 3:
//				  return '[u] [srijedu] [u] LT';
//				case 6:
//				  return '[u] [subotu] [u] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[u] dddd [u] LT'
//			  }
//			},
//			lastDay: '[jučer u] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				case 3:
//				  return '[prošlu] dddd [u] LT';
//				case 6:
//				  return '[prošle] [subote] [u] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[prošli] dddd [u] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'za %s',
//			past: 'prije %s',
//			s: 'par sekundi',
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: 'dan',
//			dd: t,
//			M: 'mjesec',
//			MM: t,
//			y: 'godinu',
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ca', {
//		  months: {
//			standalone: 'gener_febrer_març_abril_maig_juny_juliol_agost_setembre_octubre_novembre_desembre'.split('_'),
//			format: 'de gener_de febrer_de març_d\'abril_de maig_de juny_de juliol_d\'agost_de setembre_d\'octubre_de novembre_de desembre'.split('_'),
//			isFormat: /D[oD]?(\s)+MMMM/
//		  },
//		  monthsShort: 'gen._febr._març_abr._maig_juny_jul._ag._set._oct._nov._des.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'diumenge_dilluns_dimarts_dimecres_dijous_divendres_dissabte'.split('_'),
//		  weekdaysShort: 'dg._dl._dt._dc._dj._dv._ds.'.split('_'),
//		  weekdaysMin: 'dg_dl_dt_dc_dj_dv_ds'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM [de] YYYY',
//			ll: 'D MMM YYYY',
//			LLL: 'D MMMM [de] YYYY [a les] H:mm',
//			lll: 'D MMM YYYY, H:mm',
//			LLLL: 'dddd D MMMM [de] YYYY [a les] H:mm',
//			llll: 'ddd D MMM YYYY, H:mm'
//		  },
//		  calendar: {
//			sameDay: function () {
//			  return '[avui a ' + (1 !== this.hours() ? 'les' : 'la') + '] LT'
//			},
//			nextDay: function () {
//			  return '[demà a ' + (1 !== this.hours() ? 'les' : 'la') + '] LT'
//			},
//			nextWeek: function () {
//			  return 'dddd [a ' + (1 !== this.hours() ? 'les' : 'la') + '] LT'
//			},
//			lastDay: function () {
//			  return '[ahir a ' + (1 !== this.hours() ? 'les' : 'la') + '] LT'
//			},
//			lastWeek: function () {
//			  return '[el] dddd [passat a ' + (1 !== this.hours() ? 'les' : 'la') + '] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'd\'aquí %s',
//			past: 'fa %s',
//			s: 'uns segons',
//			ss: '%d segons',
//			m: 'un minut',
//			mm: '%d minuts',
//			h: 'una hora',
//			hh: '%d hores',
//			d: 'un dia',
//			dd: '%d dies',
//			M: 'un mes',
//			MM: '%d mesos',
//			y: 'un any',
//			yy: '%d anys'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(r|n|t|è|a)/,
//		  ordinal: function (e, t) {
//			var n = 1 === e ? 'r' : 2 === e ? 'n' : 3 === e ? 'r' : 4 === e ? 't' : 'è';
//			return 'w' !== t && 'W' !== t || (n = 'a'),
//			e + n
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e) {
//		  return e > 1 && e < 5 && 1 != ~~(e / 10)
//		}
//		function n(e, n, r, a) {
//		  var o = e + ' ';
//		  switch (r) {
//			case 's':
//			  return n || a ? 'pár sekund' : 'pár sekundami';
//			case 'ss':
//			  return n || a ? o + (t(e) ? 'sekundy' : 'sekund')  : o + 'sekundami';
//			case 'm':
//			  return n ? 'minuta' : a ? 'minutu' : 'minutou';
//			case 'mm':
//			  return n || a ? o + (t(e) ? 'minuty' : 'minut')  : o + 'minutami';
//			case 'h':
//			  return n ? 'hodina' : a ? 'hodinu' : 'hodinou';
//			case 'hh':
//			  return n || a ? o + (t(e) ? 'hodiny' : 'hodin')  : o + 'hodinami';
//			case 'd':
//			  return n || a ? 'den' : 'dnem';
//			case 'dd':
//			  return n || a ? o + (t(e) ? 'dny' : 'dní')  : o + 'dny';
//			case 'M':
//			  return n || a ? 'měsíc' : 'měsícem';
//			case 'MM':
//			  return n || a ? o + (t(e) ? 'měsíce' : 'měsíců')  : o + 'měsíci';
//			case 'y':
//			  return n || a ? 'rok' : 'rokem';
//			case 'yy':
//			  return n || a ? o + (t(e) ? 'roky' : 'let' )  : o + 'lety'
//		  }
//		}
//		var r = 'leden_únor_březen_duben_květen_červen_červenec_srpen_září_říjen_listopad_prosinec'.split('_'),
//		a = 'led_úno_bře_dub_kvě_čvn_čvc_srp_zář_říj_lis_pro'.split('_');
//		return e.defineLocale('cs', {
//		  months: r,
//		  monthsShort: a,
//		  monthsParse: function (e, t) {
//			var n,
//			r = [
//			];
//			for (n = 0; n < 12; n++) r[n] = new RegExp('^' + e[n] + '$|^' + t[n] + '$', 'i');
//			return r
//		  }(r, a),
//		  shortMonthsParse: function (e) {
//			var t,
//			n = [
//			];
//			for (t = 0; t < 12; t++) n[t] = new RegExp('^' + e[t] + '$', 'i');
//			return n
//		  }(a),
//		  longMonthsParse: function (e) {
//			var t,
//			n = [
//			];
//			for (t = 0; t < 12; t++) n[t] = new RegExp('^' + e[t] + '$', 'i');
//			return n
//		  }(r),
//		  weekdays: 'neděle_pondělí_úterý_středa_čtvrtek_pátek_sobota'.split('_'),
//		  weekdaysShort: 'ne_po_út_st_čt_pá_so'.split('_'),
//		  weekdaysMin: 'ne_po_út_st_čt_pá_so'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm',
//			LLLL: 'dddd D. MMMM YYYY H:mm',
//			l: 'D. M. YYYY'
//		  },
//		  calendar: {
//			sameDay: '[dnes v] LT',
//			nextDay: '[zítra v] LT',
//			nextWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[v neděli v] LT';
//				case 1:
//				case 2:
//				  return '[v] dddd [v] LT';
//				case 3:
//				  return '[ve středu v] LT';
//				case 4:
//				  return '[ve čtvrtek v] LT';
//				case 5:
//				  return '[v pátek v] LT';
//				case 6:
//				  return '[v sobotu v] LT'
//			  }
//			},
//			lastDay: '[včera v] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[minulou neděli v] LT';
//				case 1:
//				case 2:
//				  return '[minulé] dddd [v] LT';
//				case 3:
//				  return '[minulou středu v] LT';
//				case 4:
//				case 5:
//				  return '[minulý] dddd [v] LT';
//				case 6:
//				  return '[minulou sobotu v] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'za %s',
//			past: 'před %s',
//			s: n,
//			ss: n,
//			m: n,
//			mm: n,
//			h: n,
//			hh: n,
//			d: n,
//			dd: n,
//			M: n,
//			MM: n,
//			y: n,
//			yy: n
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('cv', {
//		  months: 'кӑрлач_нарӑс_пуш_ака_май_ҫӗртме_утӑ_ҫурла_авӑн_юпа_чӳк_раштав'.split('_'),
//		  monthsShort: 'кӑр_нар_пуш_ака_май_ҫӗр_утӑ_ҫур_авн_юпа_чӳк_раш'.split('_'),
//		  weekdays: 'вырсарникун_тунтикун_ытларикун_юнкун_кӗҫнерникун_эрнекун_шӑматкун'.split('_'),
//		  weekdaysShort: 'выр_тун_ытл_юн_кӗҫ_эрн_шӑм'.split('_'),
//		  weekdaysMin: 'вр_тн_ыт_юн_кҫ_эр_шм'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD-MM-YYYY',
//			LL: 'YYYY [ҫулхи] MMMM [уйӑхӗн] D[-мӗшӗ]',
//			LLL: 'YYYY [ҫулхи] MMMM [уйӑхӗн] D[-мӗшӗ], HH:mm',
//			LLLL: 'dddd, YYYY [ҫулхи] MMMM [уйӑхӗн] D[-мӗшӗ], HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Паян] LT [сехетре]',
//			nextDay: '[Ыран] LT [сехетре]',
//			lastDay: '[Ӗнер] LT [сехетре]',
//			nextWeek: '[Ҫитес] dddd LT [сехетре]',
//			lastWeek: '[Иртнӗ] dddd LT [сехетре]',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: function (e) {
//			  return e + (/сехет$/i.exec(e) ? 'рен' : /ҫул$/i.exec(e) ? 'тан' : 'ран')
//			},
//			past: '%s каялла',
//			s: 'пӗр-ик ҫеккунт',
//			ss: '%d ҫеккунт',
//			m: 'пӗр минут',
//			mm: '%d минут',
//			h: 'пӗр сехет',
//			hh: '%d сехет',
//			d: 'пӗр кун',
//			dd: '%d кун',
//			M: 'пӗр уйӑх',
//			MM: '%d уйӑх',
//			y: 'пӗр ҫул',
//			yy: '%d ҫул'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-мӗш/,
//		  ordinal: '%d-мӗш',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('cy', {
//		  months: 'Ionawr_Chwefror_Mawrth_Ebrill_Mai_Mehefin_Gorffennaf_Awst_Medi_Hydref_Tachwedd_Rhagfyr'.split('_'),
//		  monthsShort: 'Ion_Chwe_Maw_Ebr_Mai_Meh_Gor_Aws_Med_Hyd_Tach_Rhag'.split('_'),
//		  weekdays: 'Dydd Sul_Dydd Llun_Dydd Mawrth_Dydd Mercher_Dydd Iau_Dydd Gwener_Dydd Sadwrn'.split('_'),
//		  weekdaysShort: 'Sul_Llun_Maw_Mer_Iau_Gwe_Sad'.split('_'),
//		  weekdaysMin: 'Su_Ll_Ma_Me_Ia_Gw_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Heddiw am] LT',
//			nextDay: '[Yfory am] LT',
//			nextWeek: 'dddd [am] LT',
//			lastDay: '[Ddoe am] LT',
//			lastWeek: 'dddd [diwethaf am] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'mewn %s',
//			past: '%s yn ôl',
//			s: 'ychydig eiliadau',
//			ss: '%d eiliad',
//			m: 'munud',
//			mm: '%d munud',
//			h: 'awr',
//			hh: '%d awr',
//			d: 'diwrnod',
//			dd: '%d diwrnod',
//			M: 'mis',
//			MM: '%d mis',
//			y: 'blwyddyn',
//			yy: '%d flynedd'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(fed|ain|af|il|ydd|ed|eg)/,
//		  ordinal: function (e) {
//			var t = e,
//			n = '',
//			r = [
//			  '',
//			  'af',
//			  'il',
//			  'ydd',
//			  'ydd',
//			  'ed',
//			  'ed',
//			  'ed',
//			  'fed',
//			  'fed',
//			  'fed',
//			  'eg',
//			  'fed',
//			  'eg',
//			  'eg',
//			  'fed',
//			  'eg',
//			  'eg',
//			  'fed',
//			  'eg',
//			  'fed'
//			];
//			return t > 20 ? n = 40 === t || 50 === t || 60 === t || 80 === t || 100 === t ? 'fed' : 'ain' : t > 0 && (n = r[t]),
//			e + n
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('da', {
//		  months: 'januar_februar_marts_april_maj_juni_juli_august_september_oktober_november_december'.split('_'),
//		  monthsShort: 'jan_feb_mar_apr_maj_jun_jul_aug_sep_okt_nov_dec'.split('_'),
//		  weekdays: 'søndag_mandag_tirsdag_onsdag_torsdag_fredag_lørdag'.split('_'),
//		  weekdaysShort: 'søn_man_tir_ons_tor_fre_lør'.split('_'),
//		  weekdaysMin: 'sø_ma_ti_on_to_fr_lø'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY HH:mm',
//			LLLL: 'dddd [d.] D. MMMM YYYY [kl.] HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[i dag kl.] LT',
//			nextDay: '[i morgen kl.] LT',
//			nextWeek: 'på dddd [kl.] LT',
//			lastDay: '[i går kl.] LT',
//			lastWeek: '[i] dddd[s kl.] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'om %s',
//			past: '%s siden',
//			s: 'få sekunder',
//			ss: '%d sekunder',
//			m: 'et minut',
//			mm: '%d minutter',
//			h: 'en time',
//			hh: '%d timer',
//			d: 'en dag',
//			dd: '%d dage',
//			M: 'en måned',
//			MM: '%d måneder',
//			y: 'et år',
//			yy: '%d år'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			m: [
//			  'eine Minute',
//			  'einer Minute'
//			],
//			h: [
//			  'eine Stunde',
//			  'einer Stunde'
//			],
//			d: [
//			  'ein Tag',
//			  'einem Tag'
//			],
//			dd: [
//			  e + ' Tage',
//			  e + ' Tagen'
//			],
//			M: [
//			  'ein Monat',
//			  'einem Monat'
//			],
//			MM: [
//			  e + ' Monate',
//			  e + ' Monaten'
//			],
//			y: [
//			  'ein Jahr',
//			  'einem Jahr'
//			],
//			yy: [
//			  e + ' Jahre',
//			  e + ' Jahren'
//			]
//		  };
//		  return t ? a[n][0] : a[n][1]
//		}
//		return e.defineLocale('de', {
//		  months: 'Januar_Februar_März_April_Mai_Juni_Juli_August_September_Oktober_November_Dezember'.split('_'),
//		  monthsShort: 'Jan._Feb._März_Apr._Mai_Juni_Juli_Aug._Sep._Okt._Nov._Dez.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'Sonntag_Montag_Dienstag_Mittwoch_Donnerstag_Freitag_Samstag'.split('_'),
//		  weekdaysShort: 'So._Mo._Di._Mi._Do._Fr._Sa.'.split('_'),
//		  weekdaysMin: 'So_Mo_Di_Mi_Do_Fr_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY HH:mm',
//			LLLL: 'dddd, D. MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[heute um] LT [Uhr]',
//			sameElse: 'L',
//			nextDay: '[morgen um] LT [Uhr]',
//			nextWeek: 'dddd [um] LT [Uhr]',
//			lastDay: '[gestern um] LT [Uhr]',
//			lastWeek: '[letzten] dddd [um] LT [Uhr]'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: 'vor %s',
//			s: 'ein paar Sekunden',
//			ss: '%d Sekunden',
//			m: t,
//			mm: '%d Minuten',
//			h: t,
//			hh: '%d Stunden',
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			m: [
//			  'eine Minute',
//			  'einer Minute'
//			],
//			h: [
//			  'eine Stunde',
//			  'einer Stunde'
//			],
//			d: [
//			  'ein Tag',
//			  'einem Tag'
//			],
//			dd: [
//			  e + ' Tage',
//			  e + ' Tagen'
//			],
//			M: [
//			  'ein Monat',
//			  'einem Monat'
//			],
//			MM: [
//			  e + ' Monate',
//			  e + ' Monaten'
//			],
//			y: [
//			  'ein Jahr',
//			  'einem Jahr'
//			],
//			yy: [
//			  e + ' Jahre',
//			  e + ' Jahren'
//			]
//		  };
//		  return t ? a[n][0] : a[n][1]
//		}
//		return e.defineLocale('de-at', {
//		  months: 'Jänner_Februar_März_April_Mai_Juni_Juli_August_September_Oktober_November_Dezember'.split('_'),
//		  monthsShort: 'Jän._Feb._März_Apr._Mai_Juni_Juli_Aug._Sep._Okt._Nov._Dez.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'Sonntag_Montag_Dienstag_Mittwoch_Donnerstag_Freitag_Samstag'.split('_'),
//		  weekdaysShort: 'So._Mo._Di._Mi._Do._Fr._Sa.'.split('_'),
//		  weekdaysMin: 'So_Mo_Di_Mi_Do_Fr_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY HH:mm',
//			LLLL: 'dddd, D. MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[heute um] LT [Uhr]',
//			sameElse: 'L',
//			nextDay: '[morgen um] LT [Uhr]',
//			nextWeek: 'dddd [um] LT [Uhr]',
//			lastDay: '[gestern um] LT [Uhr]',
//			lastWeek: '[letzten] dddd [um] LT [Uhr]'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: 'vor %s',
//			s: 'ein paar Sekunden',
//			ss: '%d Sekunden',
//			m: t,
//			mm: '%d Minuten',
//			h: t,
//			hh: '%d Stunden',
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			m: [
//			  'eine Minute',
//			  'einer Minute'
//			],
//			h: [
//			  'eine Stunde',
//			  'einer Stunde'
//			],
//			d: [
//			  'ein Tag',
//			  'einem Tag'
//			],
//			dd: [
//			  e + ' Tage',
//			  e + ' Tagen'
//			],
//			M: [
//			  'ein Monat',
//			  'einem Monat'
//			],
//			MM: [
//			  e + ' Monate',
//			  e + ' Monaten'
//			],
//			y: [
//			  'ein Jahr',
//			  'einem Jahr'
//			],
//			yy: [
//			  e + ' Jahre',
//			  e + ' Jahren'
//			]
//		  };
//		  return t ? a[n][0] : a[n][1]
//		}
//		return e.defineLocale('de-ch', {
//		  months: 'Januar_Februar_März_April_Mai_Juni_Juli_August_September_Oktober_November_Dezember'.split('_'),
//		  monthsShort: 'Jan._Feb._März_Apr._Mai_Juni_Juli_Aug._Sep._Okt._Nov._Dez.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'Sonntag_Montag_Dienstag_Mittwoch_Donnerstag_Freitag_Samstag'.split('_'),
//		  weekdaysShort: 'So_Mo_Di_Mi_Do_Fr_Sa'.split('_'),
//		  weekdaysMin: 'So_Mo_Di_Mi_Do_Fr_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY HH:mm',
//			LLLL: 'dddd, D. MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[heute um] LT [Uhr]',
//			sameElse: 'L',
//			nextDay: '[morgen um] LT [Uhr]',
//			nextWeek: 'dddd [um] LT [Uhr]',
//			lastDay: '[gestern um] LT [Uhr]',
//			lastWeek: '[letzten] dddd [um] LT [Uhr]'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: 'vor %s',
//			s: 'ein paar Sekunden',
//			ss: '%d Sekunden',
//			m: t,
//			mm: '%d Minuten',
//			h: t,
//			hh: '%d Stunden',
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = [
//		  'ޖެނުއަރީ',
//		  'ފެބްރުއަރީ',
//		  'މާރިޗު',
//		  'އޭޕްރީލު',
//		  'މޭ',
//		  'ޖޫން',
//		  'ޖުލައި',
//		  'އޯގަސްޓު',
//		  'ސެޕްޓެމްބަރު',
//		  'އޮކްޓޯބަރު',
//		  'ނޮވެމްބަރު',
//		  'ޑިސެމްބަރު'
//		],
//		n = [
//		  'އާދިއްތަ',
//		  'ހޯމަ',
//		  'އަންގާރަ',
//		  'ބުދަ',
//		  'ބުރާސްފަތި',
//		  'ހުކުރު',
//		  'ހޮނިހިރު'
//		];
//		return e.defineLocale('dv', {
//		  months: t,
//		  monthsShort: t,
//		  weekdays: n,
//		  weekdaysShort: n,
//		  weekdaysMin: 'އާދި_ހޯމަ_އަން_ބުދަ_ބުރާ_ހުކު_ހޮނި'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'D/M/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /މކ|މފ/,
//		  isPM: function (e) {
//			return 'މފ' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'މކ' : 'މފ'
//		  },
//		  calendar: {
//			sameDay: '[މިއަދު] LT',
//			nextDay: '[މާދަމާ] LT',
//			nextWeek: 'dddd LT',
//			lastDay: '[އިއްޔެ] LT',
//			lastWeek: '[ފާއިތުވި] dddd LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'ތެރޭގައި %s',
//			past: 'ކުރިން %s',
//			s: 'ސިކުންތުކޮޅެއް',
//			ss: 'd% ސިކުންތު',
//			m: 'މިނިޓެއް',
//			mm: 'މިނިޓު %d',
//			h: 'ގަޑިއިރެއް',
//			hh: 'ގަޑިއިރު %d',
//			d: 'ދުވަހެއް',
//			dd: 'ދުވަސް %d',
//			M: 'މަހެއް',
//			MM: 'މަސް %d',
//			y: 'އަހަރެއް',
//			yy: 'އަހަރު %d'
//		  },
//		  preparse: function (e) {
//			return e.replace(/،/g, ',')
//		  },
//		  postformat: function (e) {
//			return e.replace(/,/g, '،')
//		  },
//		  week: {
//			dow: 7,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e) {
//		  return e instanceof Function || '[object Function]' === Object.prototype.toString.call(e)
//		}
//		return e.defineLocale('el', {
//		  monthsNominativeEl: 'Ιανουάριος_Φεβρουάριος_Μάρτιος_Απρίλιος_Μάιος_Ιούνιος_Ιούλιος_Αύγουστος_Σεπτέμβριος_Οκτώβριος_Νοέμβριος_Δεκέμβριος'.split('_'),
//		  monthsGenitiveEl: 'Ιανουαρίου_Φεβρουαρίου_Μαρτίου_Απριλίου_Μαΐου_Ιουνίου_Ιουλίου_Αυγούστου_Σεπτεμβρίου_Οκτωβρίου_Νοεμβρίου_Δεκεμβρίου'.split('_'),
//		  months: function (e, t) {
//			return e ? 'string' == typeof t && /D/.test(t.substring(0, t.indexOf('MMMM'))) ? this._monthsGenitiveEl[e.month()] : this._monthsNominativeEl[e.month()] : this._monthsNominativeEl
//		  },
//		  monthsShort: 'Ιαν_Φεβ_Μαρ_Απρ_Μαϊ_Ιουν_Ιουλ_Αυγ_Σεπ_Οκτ_Νοε_Δεκ'.split('_'),
//		  weekdays: 'Κυριακή_Δευτέρα_Τρίτη_Τετάρτη_Πέμπτη_Παρασκευή_Σάββατο'.split('_'),
//		  weekdaysShort: 'Κυρ_Δευ_Τρι_Τετ_Πεμ_Παρ_Σαβ'.split('_'),
//		  weekdaysMin: 'Κυ_Δε_Τρ_Τε_Πε_Πα_Σα'.split('_'),
//		  meridiem: function (e, t, n) {
//			return e > 11 ? n ? 'μμ' : 'ΜΜ' : n ? 'πμ' : 'ΠΜ'
//		  },
//		  isPM: function (e) {
//			return 'μ' === (e + '').toLowerCase() [0]
//		  },
//		  meridiemParse: /[ΠΜ]\.?Μ?\.?/i,
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY h:mm A',
//			LLLL: 'dddd, D MMMM YYYY h:mm A'
//		  },
//		  calendarEl: {
//			sameDay: '[Σήμερα {}] LT',
//			nextDay: '[Αύριο {}] LT',
//			nextWeek: 'dddd [{}] LT',
//			lastDay: '[Χθες {}] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 6:
//				  return '[το προηγούμενο] dddd [{}] LT';
//				default:
//				  return '[την προηγούμενη] dddd [{}] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  calendar: function (e, n) {
//			var r = this._calendarEl[e],
//			a = n && n.hours();
//			return t(r) && (r = r.apply(n)),
//			r.replace('{}', a % 12 == 1 ? 'στη' : 'στις')
//		  },
//		  relativeTime: {
//			future: 'σε %s',
//			past: '%s πριν',
//			s: 'λίγα δευτερόλεπτα',
//			ss: '%d δευτερόλεπτα',
//			m: 'ένα λεπτό',
//			mm: '%d λεπτά',
//			h: 'μία ώρα',
//			hh: '%d ώρες',
//			d: 'μία μέρα',
//			dd: '%d μέρες',
//			M: 'ένας μήνας',
//			MM: '%d μήνες',
//			y: 'ένας χρόνος',
//			yy: '%d χρόνια'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}η/,
//		  ordinal: '%dη',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('en-au', {
//		  months: 'January_February_March_April_May_June_July_August_September_October_November_December'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec'.split('_'),
//		  weekdays: 'Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday'.split('_'),
//		  weekdaysShort: 'Sun_Mon_Tue_Wed_Thu_Fri_Sat'.split('_'),
//		  weekdaysMin: 'Su_Mo_Tu_We_Th_Fr_Sa'.split('_'),
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY h:mm A',
//			LLLL: 'dddd, D MMMM YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: '[Today at] LT',
//			nextDay: '[Tomorrow at] LT',
//			nextWeek: 'dddd [at] LT',
//			lastDay: '[Yesterday at] LT',
//			lastWeek: '[Last] dddd [at] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: '%s ago',
//			s: 'a few seconds',
//			ss: '%d seconds',
//			m: 'a minute',
//			mm: '%d minutes',
//			h: 'an hour',
//			hh: '%d hours',
//			d: 'a day',
//			dd: '%d days',
//			M: 'a month',
//			MM: '%d months',
//			y: 'a year',
//			yy: '%d years'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//		  ordinal: function (e) {
//			var t = e % 10;
//			return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('en-ca', {
//		  months: 'January_February_March_April_May_June_July_August_September_October_November_December'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec'.split('_'),
//		  weekdays: 'Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday'.split('_'),
//		  weekdaysShort: 'Sun_Mon_Tue_Wed_Thu_Fri_Sat'.split('_'),
//		  weekdaysMin: 'Su_Mo_Tu_We_Th_Fr_Sa'.split('_'),
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'YYYY-MM-DD',
//			LL: 'MMMM D, YYYY',
//			LLL: 'MMMM D, YYYY h:mm A',
//			LLLL: 'dddd, MMMM D, YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: '[Today at] LT',
//			nextDay: '[Tomorrow at] LT',
//			nextWeek: 'dddd [at] LT',
//			lastDay: '[Yesterday at] LT',
//			lastWeek: '[Last] dddd [at] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: '%s ago',
//			s: 'a few seconds',
//			ss: '%d seconds',
//			m: 'a minute',
//			mm: '%d minutes',
//			h: 'an hour',
//			hh: '%d hours',
//			d: 'a day',
//			dd: '%d days',
//			M: 'a month',
//			MM: '%d months',
//			y: 'a year',
//			yy: '%d years'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//		  ordinal: function (e) {
//			var t = e % 10;
//			return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('en-gb', {
//		  months: 'January_February_March_April_May_June_July_August_September_October_November_December'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec'.split('_'),
//		  weekdays: 'Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday'.split('_'),
//		  weekdaysShort: 'Sun_Mon_Tue_Wed_Thu_Fri_Sat'.split('_'),
//		  weekdaysMin: 'Su_Mo_Tu_We_Th_Fr_Sa'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Today at] LT',
//			nextDay: '[Tomorrow at] LT',
//			nextWeek: 'dddd [at] LT',
//			lastDay: '[Yesterday at] LT',
//			lastWeek: '[Last] dddd [at] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: '%s ago',
//			s: 'a few seconds',
//			ss: '%d seconds',
//			m: 'a minute',
//			mm: '%d minutes',
//			h: 'an hour',
//			hh: '%d hours',
//			d: 'a day',
//			dd: '%d days',
//			M: 'a month',
//			MM: '%d months',
//			y: 'a year',
//			yy: '%d years'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//		  ordinal: function (e) {
//			var t = e % 10;
//			return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('en-ie', {
//		  months: 'January_February_March_April_May_June_July_August_September_October_November_December'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec'.split('_'),
//		  weekdays: 'Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday'.split('_'),
//		  weekdaysShort: 'Sun_Mon_Tue_Wed_Thu_Fri_Sat'.split('_'),
//		  weekdaysMin: 'Su_Mo_Tu_We_Th_Fr_Sa'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD-MM-YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Today at] LT',
//			nextDay: '[Tomorrow at] LT',
//			nextWeek: 'dddd [at] LT',
//			lastDay: '[Yesterday at] LT',
//			lastWeek: '[Last] dddd [at] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: '%s ago',
//			s: 'a few seconds',
//			ss: '%d seconds',
//			m: 'a minute',
//			mm: '%d minutes',
//			h: 'an hour',
//			hh: '%d hours',
//			d: 'a day',
//			dd: '%d days',
//			M: 'a month',
//			MM: '%d months',
//			y: 'a year',
//			yy: '%d years'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//		  ordinal: function (e) {
//			var t = e % 10;
//			return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('en-nz', {
//		  months: 'January_February_March_April_May_June_July_August_September_October_November_December'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_May_Jun_Jul_Aug_Sep_Oct_Nov_Dec'.split('_'),
//		  weekdays: 'Sunday_Monday_Tuesday_Wednesday_Thursday_Friday_Saturday'.split('_'),
//		  weekdaysShort: 'Sun_Mon_Tue_Wed_Thu_Fri_Sat'.split('_'),
//		  weekdaysMin: 'Su_Mo_Tu_We_Th_Fr_Sa'.split('_'),
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY h:mm A',
//			LLLL: 'dddd, D MMMM YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: '[Today at] LT',
//			nextDay: '[Tomorrow at] LT',
//			nextWeek: 'dddd [at] LT',
//			lastDay: '[Yesterday at] LT',
//			lastWeek: '[Last] dddd [at] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'in %s',
//			past: '%s ago',
//			s: 'a few seconds',
//			ss: '%d seconds',
//			m: 'a minute',
//			mm: '%d minutes',
//			h: 'an hour',
//			hh: '%d hours',
//			d: 'a day',
//			dd: '%d days',
//			M: 'a month',
//			MM: '%d months',
//			y: 'a year',
//			yy: '%d years'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//		  ordinal: function (e) {
//			var t = e % 10;
//			return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('eo', {
//		  months: 'januaro_februaro_marto_aprilo_majo_junio_julio_aŭgusto_septembro_oktobro_novembro_decembro'.split('_'),
//		  monthsShort: 'jan_feb_mar_apr_maj_jun_jul_aŭg_sep_okt_nov_dec'.split('_'),
//		  weekdays: 'dimanĉo_lundo_mardo_merkredo_ĵaŭdo_vendredo_sabato'.split('_'),
//		  weekdaysShort: 'dim_lun_mard_merk_ĵaŭ_ven_sab'.split('_'),
//		  weekdaysMin: 'di_lu_ma_me_ĵa_ve_sa'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'YYYY-MM-DD',
//			LL: 'D[-a de] MMMM, YYYY',
//			LLL: 'D[-a de] MMMM, YYYY HH:mm',
//			LLLL: 'dddd, [la] D[-a de] MMMM, YYYY HH:mm'
//		  },
//		  meridiemParse: /[ap]\.t\.m/i,
//		  isPM: function (e) {
//			return 'p' === e.charAt(0).toLowerCase()
//		  },
//		  meridiem: function (e, t, n) {
//			return e > 11 ? n ? 'p.t.m.' : 'P.T.M.' : n ? 'a.t.m.' : 'A.T.M.'
//		  },
//		  calendar: {
//			sameDay: '[Hodiaŭ je] LT',
//			nextDay: '[Morgaŭ je] LT',
//			nextWeek: 'dddd [je] LT',
//			lastDay: '[Hieraŭ je] LT',
//			lastWeek: '[pasinta] dddd [je] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'post %s',
//			past: 'antaŭ %s',
//			s: 'sekundoj',
//			ss: '%d sekundoj',
//			m: 'minuto',
//			mm: '%d minutoj',
//			h: 'horo',
//			hh: '%d horoj',
//			d: 'tago',
//			dd: '%d tagoj',
//			M: 'monato',
//			MM: '%d monatoj',
//			y: 'jaro',
//			yy: '%d jaroj'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}a/,
//		  ordinal: '%da',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = 'ene._feb._mar._abr._may._jun._jul._ago._sep._oct._nov._dic.'.split('_'),
//		n = 'ene_feb_mar_abr_may_jun_jul_ago_sep_oct_nov_dic'.split('_'),
//		r = [
//		  /^ene/i,
//		  /^feb/i,
//		  /^mar/i,
//		  /^abr/i,
//		  /^may/i,
//		  /^jun/i,
//		  /^jul/i,
//		  /^ago/i,
//		  /^sep/i,
//		  /^oct/i,
//		  /^nov/i,
//		  /^dic/i
//		],
//		a = /^(enero|febrero|marzo|abril|mayo|junio|julio|agosto|septiembre|octubre|noviembre|diciembre|ene\.?|feb\.?|mar\.?|abr\.?|may\.?|jun\.?|jul\.?|ago\.?|sep\.?|oct\.?|nov\.?|dic\.?)/i;
//		return e.defineLocale('es', {
//		  months: 'enero_febrero_marzo_abril_mayo_junio_julio_agosto_septiembre_octubre_noviembre_diciembre'.split('_'),
//		  monthsShort: function (e, r) {
//			return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//		  },
//		  monthsRegex: a,
//		  monthsShortRegex: a,
//		  monthsStrictRegex: /^(enero|febrero|marzo|abril|mayo|junio|julio|agosto|septiembre|octubre|noviembre|diciembre)/i,
//		  monthsShortStrictRegex: /^(ene\.?|feb\.?|mar\.?|abr\.?|may\.?|jun\.?|jul\.?|ago\.?|sep\.?|oct\.?|nov\.?|dic\.?)/i,
//		  monthsParse: r,
//		  longMonthsParse: r,
//		  shortMonthsParse: r,
//		  weekdays: 'domingo_lunes_martes_miércoles_jueves_viernes_sábado'.split('_'),
//		  weekdaysShort: 'dom._lun._mar._mié._jue._vie._sáb.'.split('_'),
//		  weekdaysMin: 'do_lu_ma_mi_ju_vi_sá'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D [de] MMMM [de] YYYY',
//			LLL: 'D [de] MMMM [de] YYYY H:mm',
//			LLLL: 'dddd, D [de] MMMM [de] YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: function () {
//			  return '[hoy a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextDay: function () {
//			  return '[mañana a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextWeek: function () {
//			  return 'dddd [a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastDay: function () {
//			  return '[ayer a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastWeek: function () {
//			  return '[el] dddd [pasado a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'en %s',
//			past: 'hace %s',
//			s: 'unos segundos',
//			ss: '%d segundos',
//			m: 'un minuto',
//			mm: '%d minutos',
//			h: 'una hora',
//			hh: '%d horas',
//			d: 'un día',
//			dd: '%d días',
//			M: 'un mes',
//			MM: '%d meses',
//			y: 'un año',
//			yy: '%d años'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = 'ene._feb._mar._abr._may._jun._jul._ago._sep._oct._nov._dic.'.split('_'),
//		n = 'ene_feb_mar_abr_may_jun_jul_ago_sep_oct_nov_dic'.split('_'),
//		r = [
//		  /^ene/i,
//		  /^feb/i,
//		  /^mar/i,
//		  /^abr/i,
//		  /^may/i,
//		  /^jun/i,
//		  /^jul/i,
//		  /^ago/i,
//		  /^sep/i,
//		  /^oct/i,
//		  /^nov/i,
//		  /^dic/i
//		],
//		a = /^(enero|febrero|marzo|abril|mayo|junio|julio|agosto|septiembre|octubre|noviembre|diciembre|ene\.?|feb\.?|mar\.?|abr\.?|may\.?|jun\.?|jul\.?|ago\.?|sep\.?|oct\.?|nov\.?|dic\.?)/i;
//		return e.defineLocale('es-do', {
//		  months: 'enero_febrero_marzo_abril_mayo_junio_julio_agosto_septiembre_octubre_noviembre_diciembre'.split('_'),
//		  monthsShort: function (e, r) {
//			return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//		  },
//		  monthsRegex: a,
//		  monthsShortRegex: a,
//		  monthsStrictRegex: /^(enero|febrero|marzo|abril|mayo|junio|julio|agosto|septiembre|octubre|noviembre|diciembre)/i,
//		  monthsShortStrictRegex: /^(ene\.?|feb\.?|mar\.?|abr\.?|may\.?|jun\.?|jul\.?|ago\.?|sep\.?|oct\.?|nov\.?|dic\.?)/i,
//		  monthsParse: r,
//		  longMonthsParse: r,
//		  shortMonthsParse: r,
//		  weekdays: 'domingo_lunes_martes_miércoles_jueves_viernes_sábado'.split('_'),
//		  weekdaysShort: 'dom._lun._mar._mié._jue._vie._sáb.'.split('_'),
//		  weekdaysMin: 'do_lu_ma_mi_ju_vi_sá'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D [de] MMMM [de] YYYY',
//			LLL: 'D [de] MMMM [de] YYYY h:mm A',
//			LLLL: 'dddd, D [de] MMMM [de] YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: function () {
//			  return '[hoy a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextDay: function () {
//			  return '[mañana a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextWeek: function () {
//			  return 'dddd [a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastDay: function () {
//			  return '[ayer a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastWeek: function () {
//			  return '[el] dddd [pasado a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'en %s',
//			past: 'hace %s',
//			s: 'unos segundos',
//			ss: '%d segundos',
//			m: 'un minuto',
//			mm: '%d minutos',
//			h: 'una hora',
//			hh: '%d horas',
//			d: 'un día',
//			dd: '%d días',
//			M: 'un mes',
//			MM: '%d meses',
//			y: 'un año',
//			yy: '%d años'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = 'ene._feb._mar._abr._may._jun._jul._ago._sep._oct._nov._dic.'.split('_'),
//		n = 'ene_feb_mar_abr_may_jun_jul_ago_sep_oct_nov_dic'.split('_');
//		return e.defineLocale('es-us', {
//		  months: 'enero_febrero_marzo_abril_mayo_junio_julio_agosto_septiembre_octubre_noviembre_diciembre'.split('_'),
//		  monthsShort: function (e, r) {
//			return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//		  },
//		  monthsParseExact: !0,
//		  weekdays: 'domingo_lunes_martes_miércoles_jueves_viernes_sábado'.split('_'),
//		  weekdaysShort: 'dom._lun._mar._mié._jue._vie._sáb.'.split('_'),
//		  weekdaysMin: 'do_lu_ma_mi_ju_vi_sá'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'MM/DD/YYYY',
//			LL: 'MMMM [de] D [de] YYYY',
//			LLL: 'MMMM [de] D [de] YYYY h:mm A',
//			LLLL: 'dddd, MMMM [de] D [de] YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: function () {
//			  return '[hoy a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextDay: function () {
//			  return '[mañana a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			nextWeek: function () {
//			  return 'dddd [a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastDay: function () {
//			  return '[ayer a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			lastWeek: function () {
//			  return '[el] dddd [pasado a la' + (1 !== this.hours() ? 's' : '') + '] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'en %s',
//			past: 'hace %s',
//			s: 'unos segundos',
//			ss: '%d segundos',
//			m: 'un minuto',
//			mm: '%d minutos',
//			h: 'una hora',
//			hh: '%d horas',
//			d: 'un día',
//			dd: '%d días',
//			M: 'un mes',
//			MM: '%d meses',
//			y: 'un año',
//			yy: '%d años'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			s: [
//			  'mõne sekundi',
//			  'mõni sekund',
//			  'paar sekundit'
//			],
//			ss: [
//			  e + 'sekundi',
//			  e + 'sekundit'
//			],
//			m: [
//			  'ühe minuti',
//			  'üks minut'
//			],
//			mm: [
//			  e + ' minuti',
//			  e + ' minutit'
//			],
//			h: [
//			  'ühe tunni',
//			  'tund aega',
//			  'üks tund'
//			],
//			hh: [
//			  e + ' tunni',
//			  e + ' tundi'
//			],
//			d: [
//			  'ühe päeva',
//			  'üks päev'
//			],
//			M: [
//			  'kuu aja',
//			  'kuu aega',
//			  'üks kuu'
//			],
//			MM: [
//			  e + ' kuu',
//			  e + ' kuud'
//			],
//			y: [
//			  'ühe aasta',
//			  'aasta',
//			  'üks aasta'
//			],
//			yy: [
//			  e + ' aasta',
//			  e + ' aastat'
//			]
//		  };
//		  return t ? a[n][2] ? a[n][2] : a[n][1] : r ? a[n][0] : a[n][1]
//		}
//		return e.defineLocale('et', {
//		  months: 'jaanuar_veebruar_märts_aprill_mai_juuni_juuli_august_september_oktoober_november_detsember'.split('_'),
//		  monthsShort: 'jaan_veebr_märts_apr_mai_juuni_juuli_aug_sept_okt_nov_dets'.split('_'),
//		  weekdays: 'pühapäev_esmaspäev_teisipäev_kolmapäev_neljapäev_reede_laupäev'.split('_'),
//		  weekdaysShort: 'P_E_T_K_N_R_L'.split('_'),
//		  weekdaysMin: 'P_E_T_K_N_R_L'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm',
//			LLLL: 'dddd, D. MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[Täna,] LT',
//			nextDay: '[Homme,] LT',
//			nextWeek: '[Järgmine] dddd LT',
//			lastDay: '[Eile,] LT',
//			lastWeek: '[Eelmine] dddd LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s pärast',
//			past: '%s tagasi',
//			s: t,
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: t,
//			dd: '%d päeva',
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('eu', {
//		  months: 'urtarrila_otsaila_martxoa_apirila_maiatza_ekaina_uztaila_abuztua_iraila_urria_azaroa_abendua'.split('_'),
//		  monthsShort: 'urt._ots._mar._api._mai._eka._uzt._abu._ira._urr._aza._abe.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'igandea_astelehena_asteartea_asteazkena_osteguna_ostirala_larunbata'.split('_'),
//		  weekdaysShort: 'ig._al._ar._az._og._ol._lr.'.split('_'),
//		  weekdaysMin: 'ig_al_ar_az_og_ol_lr'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'YYYY-MM-DD',
//			LL: 'YYYY[ko] MMMM[ren] D[a]',
//			LLL: 'YYYY[ko] MMMM[ren] D[a] HH:mm',
//			LLLL: 'dddd, YYYY[ko] MMMM[ren] D[a] HH:mm',
//			l: 'YYYY-M-D',
//			ll: 'YYYY[ko] MMM D[a]',
//			lll: 'YYYY[ko] MMM D[a] HH:mm',
//			llll: 'ddd, YYYY[ko] MMM D[a] HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[gaur] LT[etan]',
//			nextDay: '[bihar] LT[etan]',
//			nextWeek: 'dddd LT[etan]',
//			lastDay: '[atzo] LT[etan]',
//			lastWeek: '[aurreko] dddd LT[etan]',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s barru',
//			past: 'duela %s',
//			s: 'segundo batzuk',
//			ss: '%d segundo',
//			m: 'minutu bat',
//			mm: '%d minutu',
//			h: 'ordu bat',
//			hh: '%d ordu',
//			d: 'egun bat',
//			dd: '%d egun',
//			M: 'hilabete bat',
//			MM: '%d hilabete',
//			y: 'urte bat',
//			yy: '%d urte'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '۱',
//		  2: '۲',
//		  3: '۳',
//		  4: '۴',
//		  5: '۵',
//		  6: '۶',
//		  7: '۷',
//		  8: '۸',
//		  9: '۹',
//		  0: '۰'
//		},
//		n = {
//		  '۱': '1',
//		  '۲': '2',
//		  '۳': '3',
//		  '۴': '4',
//		  '۵': '5',
//		  '۶': '6',
//		  '۷': '7',
//		  '۸': '8',
//		  '۹': '9',
//		  '۰': '0'
//		};
//		return e.defineLocale('fa', {
//		  months: 'ژانویه_فوریه_مارس_آوریل_مه_ژوئن_ژوئیه_اوت_سپتامبر_اکتبر_نوامبر_دسامبر'.split('_'),
//		  monthsShort: 'ژانویه_فوریه_مارس_آوریل_مه_ژوئن_ژوئیه_اوت_سپتامبر_اکتبر_نوامبر_دسامبر'.split('_'),
//		  weekdays: 'یک‌شنبه_دوشنبه_سه‌شنبه_چهارشنبه_پنج‌شنبه_جمعه_شنبه'.split('_'),
//		  weekdaysShort: 'یک‌شنبه_دوشنبه_سه‌شنبه_چهارشنبه_پنج‌شنبه_جمعه_شنبه'.split('_'),
//		  weekdaysMin: 'ی_د_س_چ_پ_ج_ش'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /قبل از ظهر|بعد از ظهر/,
//		  isPM: function (e) {
//			return /بعد از ظهر/.test(e)
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'قبل از ظهر' : 'بعد از ظهر'
//		  },
//		  calendar: {
//			sameDay: '[امروز ساعت] LT',
//			nextDay: '[فردا ساعت] LT',
//			nextWeek: 'dddd [ساعت] LT',
//			lastDay: '[دیروز ساعت] LT',
//			lastWeek: 'dddd [پیش] [ساعت] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'در %s',
//			past: '%s پیش',
//			s: 'چند ثانیه',
//			ss: 'ثانیه d%',
//			m: 'یک دقیقه',
//			mm: '%d دقیقه',
//			h: 'یک ساعت',
//			hh: '%d ساعت',
//			d: 'یک روز',
//			dd: '%d روز',
//			M: 'یک ماه',
//			MM: '%d ماه',
//			y: 'یک سال',
//			yy: '%d سال'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[۰-۹]/g, function (e) {
//			  return n[e]
//			}).replace(/،/g, ',')
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			}).replace(/,/g, '،')
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}م/,
//		  ordinal: '%dم',
//		  week: {
//			dow: 6,
//			doy: 12
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, r, a) {
//		  var o = '';
//		  switch (r) {
//			case 's':
//			  return a ? 'muutaman sekunnin' : 'muutama sekunti';
//			case 'ss':
//			  return a ? 'sekunnin' : 'sekuntia';
//			case 'm':
//			  return a ? 'minuutin' : 'minuutti';
//			case 'mm':
//			  o = a ? 'minuutin' : 'minuuttia';
//			  break;
//			case 'h':
//			  return a ? 'tunnin' : 'tunti';
//			case 'hh':
//			  o = a ? 'tunnin' : 'tuntia';
//			  break;
//			case 'd':
//			  return a ? 'päivän' : 'päivä';
//			case 'dd':
//			  o = a ? 'päivän' : 'päivää';
//			  break;
//			case 'M':
//			  return a ? 'kuukauden' : 'kuukausi';
//			case 'MM':
//			  o = a ? 'kuukauden' : 'kuukautta';
//			  break;
//			case 'y':
//			  return a ? 'vuoden' : 'vuosi';
//			case 'yy':
//			  o = a ? 'vuoden' : 'vuotta'
//		  }
//		  return o = n(e, a) + ' ' + o
//		}
//		function n(e, t) {
//		  return e < 10 ? t ? a[e] : r[e] : e
//		}
//		var r = 'nolla yksi kaksi kolme neljä viisi kuusi seitsemän kahdeksan yhdeksän'.split(' '),
//		a = [
//		  'nolla',
//		  'yhden',
//		  'kahden',
//		  'kolmen',
//		  'neljän',
//		  'viiden',
//		  'kuuden',
//		  r[7],
//		  r[8],
//		  r[9]
//		];
//		return e.defineLocale('fi', {
//		  months: 'tammikuu_helmikuu_maaliskuu_huhtikuu_toukokuu_kesäkuu_heinäkuu_elokuu_syyskuu_lokakuu_marraskuu_joulukuu'.split('_'),
//		  monthsShort: 'tammi_helmi_maalis_huhti_touko_kesä_heinä_elo_syys_loka_marras_joulu'.split('_'),
//		  weekdays: 'sunnuntai_maanantai_tiistai_keskiviikko_torstai_perjantai_lauantai'.split('_'),
//		  weekdaysShort: 'su_ma_ti_ke_to_pe_la'.split('_'),
//		  weekdaysMin: 'su_ma_ti_ke_to_pe_la'.split('_'),
//		  longDateFormat: {
//			LT: 'HH.mm',
//			LTS: 'HH.mm.ss',
//			L: 'DD.MM.YYYY',
//			LL: 'Do MMMM[ta] YYYY',
//			LLL: 'Do MMMM[ta] YYYY, [klo] HH.mm',
//			LLLL: 'dddd, Do MMMM[ta] YYYY, [klo] HH.mm',
//			l: 'D.M.YYYY',
//			ll: 'Do MMM YYYY',
//			lll: 'Do MMM YYYY, [klo] HH.mm',
//			llll: 'ddd, Do MMM YYYY, [klo] HH.mm'
//		  },
//		  calendar: {
//			sameDay: '[tänään] [klo] LT',
//			nextDay: '[huomenna] [klo] LT',
//			nextWeek: 'dddd [klo] LT',
//			lastDay: '[eilen] [klo] LT',
//			lastWeek: '[viime] dddd[na] [klo] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s päästä',
//			past: '%s sitten',
//			s: t,
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('fo', {
//		  months: 'januar_februar_mars_apríl_mai_juni_juli_august_september_oktober_november_desember'.split('_'),
//		  monthsShort: 'jan_feb_mar_apr_mai_jun_jul_aug_sep_okt_nov_des'.split('_'),
//		  weekdays: 'sunnudagur_mánadagur_týsdagur_mikudagur_hósdagur_fríggjadagur_leygardagur'.split('_'),
//		  weekdaysShort: 'sun_mán_týs_mik_hós_frí_ley'.split('_'),
//		  weekdaysMin: 'su_má_tý_mi_hó_fr_le'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D. MMMM, YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Í dag kl.] LT',
//			nextDay: '[Í morgin kl.] LT',
//			nextWeek: 'dddd [kl.] LT',
//			lastDay: '[Í gjár kl.] LT',
//			lastWeek: '[síðstu] dddd [kl] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'um %s',
//			past: '%s síðani',
//			s: 'fá sekund',
//			ss: '%d sekundir',
//			m: 'ein minutt',
//			mm: '%d minuttir',
//			h: 'ein tími',
//			hh: '%d tímar',
//			d: 'ein dagur',
//			dd: '%d dagar',
//			M: 'ein mánaði',
//			MM: '%d mánaðir',
//			y: 'eitt ár',
//			yy: '%d ár'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('fr', {
//		  months: 'janvier_février_mars_avril_mai_juin_juillet_août_septembre_octobre_novembre_décembre'.split('_'),
//		  monthsShort: 'janv._févr._mars_avr._mai_juin_juil._août_sept._oct._nov._déc.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'dimanche_lundi_mardi_mercredi_jeudi_vendredi_samedi'.split('_'),
//		  weekdaysShort: 'dim._lun._mar._mer._jeu._ven._sam.'.split('_'),
//		  weekdaysMin: 'di_lu_ma_me_je_ve_sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Aujourd’hui à] LT',
//			nextDay: '[Demain à] LT',
//			nextWeek: 'dddd [à] LT',
//			lastDay: '[Hier à] LT',
//			lastWeek: 'dddd [dernier à] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'dans %s',
//			past: 'il y a %s',
//			s: 'quelques secondes',
//			ss: '%d secondes',
//			m: 'une minute',
//			mm: '%d minutes',
//			h: 'une heure',
//			hh: '%d heures',
//			d: 'un jour',
//			dd: '%d jours',
//			M: 'un mois',
//			MM: '%d mois',
//			y: 'un an',
//			yy: '%d ans'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(er|)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'D':
//				return e + (1 === e ? 'er' : '');
//			  default:
//			  case 'M':
//			  case 'Q':
//			  case 'DDD':
//			  case 'd':
//				return e + (1 === e ? 'er' : 'e');
//			  case 'w':
//			  case 'W':
//				return e + (1 === e ? 're' : 'e')
//			}
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('fr-ca', {
//		  months: 'janvier_février_mars_avril_mai_juin_juillet_août_septembre_octobre_novembre_décembre'.split('_'),
//		  monthsShort: 'janv._févr._mars_avr._mai_juin_juil._août_sept._oct._nov._déc.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'dimanche_lundi_mardi_mercredi_jeudi_vendredi_samedi'.split('_'),
//		  weekdaysShort: 'dim._lun._mar._mer._jeu._ven._sam.'.split('_'),
//		  weekdaysMin: 'di_lu_ma_me_je_ve_sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'YYYY-MM-DD',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Aujourd’hui à] LT',
//			nextDay: '[Demain à] LT',
//			nextWeek: 'dddd [à] LT',
//			lastDay: '[Hier à] LT',
//			lastWeek: 'dddd [dernier à] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'dans %s',
//			past: 'il y a %s',
//			s: 'quelques secondes',
//			ss: '%d secondes',
//			m: 'une minute',
//			mm: '%d minutes',
//			h: 'une heure',
//			hh: '%d heures',
//			d: 'un jour',
//			dd: '%d jours',
//			M: 'un mois',
//			MM: '%d mois',
//			y: 'un an',
//			yy: '%d ans'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(er|e)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  default:
//			  case 'M':
//			  case 'Q':
//			  case 'D':
//			  case 'DDD':
//			  case 'd':
//				return e + (1 === e ? 'er' : 'e');
//			  case 'w':
//			  case 'W':
//				return e + (1 === e ? 're' : 'e')
//			}
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('fr-ch', {
//		  months: 'janvier_février_mars_avril_mai_juin_juillet_août_septembre_octobre_novembre_décembre'.split('_'),
//		  monthsShort: 'janv._févr._mars_avr._mai_juin_juil._août_sept._oct._nov._déc.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'dimanche_lundi_mardi_mercredi_jeudi_vendredi_samedi'.split('_'),
//		  weekdaysShort: 'dim._lun._mar._mer._jeu._ven._sam.'.split('_'),
//		  weekdaysMin: 'di_lu_ma_me_je_ve_sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Aujourd’hui à] LT',
//			nextDay: '[Demain à] LT',
//			nextWeek: 'dddd [à] LT',
//			lastDay: '[Hier à] LT',
//			lastWeek: 'dddd [dernier à] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'dans %s',
//			past: 'il y a %s',
//			s: 'quelques secondes',
//			ss: '%d secondes',
//			m: 'une minute',
//			mm: '%d minutes',
//			h: 'une heure',
//			hh: '%d heures',
//			d: 'un jour',
//			dd: '%d jours',
//			M: 'un mois',
//			MM: '%d mois',
//			y: 'un an',
//			yy: '%d ans'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(er|e)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  default:
//			  case 'M':
//			  case 'Q':
//			  case 'D':
//			  case 'DDD':
//			  case 'd':
//				return e + (1 === e ? 'er' : 'e');
//			  case 'w':
//			  case 'W':
//				return e + (1 === e ? 're' : 'e')
//			}
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = 'jan._feb._mrt._apr._mai_jun._jul._aug._sep._okt._nov._des.'.split('_'),
//		n = 'jan_feb_mrt_apr_mai_jun_jul_aug_sep_okt_nov_des'.split('_');
//		return e.defineLocale('fy', {
//		  months: 'jannewaris_febrewaris_maart_april_maaie_juny_july_augustus_septimber_oktober_novimber_desimber'.split('_'),
//		  monthsShort: function (e, r) {
//			return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//		  },
//		  monthsParseExact: !0,
//		  weekdays: 'snein_moandei_tiisdei_woansdei_tongersdei_freed_sneon'.split('_'),
//		  weekdaysShort: 'si._mo._ti._wo._to._fr._so.'.split('_'),
//		  weekdaysMin: 'Si_Mo_Ti_Wo_To_Fr_So'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD-MM-YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[hjoed om] LT',
//			nextDay: '[moarn om] LT',
//			nextWeek: 'dddd [om] LT',
//			lastDay: '[juster om] LT',
//			lastWeek: '[ôfrûne] dddd [om] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'oer %s',
//			past: '%s lyn',
//			s: 'in pear sekonden',
//			ss: '%d sekonden',
//			m: 'ien minút',
//			mm: '%d minuten',
//			h: 'ien oere',
//			hh: '%d oeren',
//			d: 'ien dei',
//			dd: '%d dagen',
//			M: 'ien moanne',
//			MM: '%d moannen',
//			y: 'ien jier',
//			yy: '%d jierren'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(ste|de)/,
//		  ordinal: function (e) {
//			return e + (1 === e || 8 === e || e >= 20 ? 'ste' : 'de')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = [
//		  'Am Faoilleach',
//		  'An Gearran',
//		  'Am Màrt',
//		  'An Giblean',
//		  'An Cèitean',
//		  'An t-Ògmhios',
//		  'An t-Iuchar',
//		  'An Lùnastal',
//		  'An t-Sultain',
//		  'An Dàmhair',
//		  'An t-Samhain',
//		  'An Dùbhlachd'
//		],
//		n = [
//		  'Faoi',
//		  'Gear',
//		  'Màrt',
//		  'Gibl',
//		  'Cèit',
//		  'Ògmh',
//		  'Iuch',
//		  'Lùn',
//		  'Sult',
//		  'Dàmh',
//		  'Samh',
//		  'Dùbh'
//		],
//		r = [
//		  'Didòmhnaich',
//		  'Diluain',
//		  'Dimàirt',
//		  'Diciadain',
//		  'Diardaoin',
//		  'Dihaoine',
//		  'Disathairne'
//		],
//		a = [
//		  'Did',
//		  'Dil',
//		  'Dim',
//		  'Dic',
//		  'Dia',
//		  'Dih',
//		  'Dis'
//		],
//		o = [
//		  'Dò',
//		  'Lu',
//		  'Mà',
//		  'Ci',
//		  'Ar',
//		  'Ha',
//		  'Sa'
//		];
//		return e.defineLocale('gd', {
//		  months: t,
//		  monthsShort: n,
//		  monthsParseExact: !0,
//		  weekdays: r,
//		  weekdaysShort: a,
//		  weekdaysMin: o,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[An-diugh aig] LT',
//			nextDay: '[A-màireach aig] LT',
//			nextWeek: 'dddd [aig] LT',
//			lastDay: '[An-dè aig] LT',
//			lastWeek: 'dddd [seo chaidh] [aig] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'ann an %s',
//			past: 'bho chionn %s',
//			s: 'beagan diogan',
//			ss: '%d diogan',
//			m: 'mionaid',
//			mm: '%d mionaidean',
//			h: 'uair',
//			hh: '%d uairean',
//			d: 'latha',
//			dd: '%d latha',
//			M: 'mìos',
//			MM: '%d mìosan',
//			y: 'bliadhna',
//			yy: '%d bliadhna'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(d|na|mh)/,
//		  ordinal: function (e) {
//			return e + (1 === e ? 'd' : e % 10 == 2 ? 'na' : 'mh')
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('gl', {
//		  months: 'xaneiro_febreiro_marzo_abril_maio_xuño_xullo_agosto_setembro_outubro_novembro_decembro'.split('_'),
//		  monthsShort: 'xan._feb._mar._abr._mai._xuñ._xul._ago._set._out._nov._dec.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'domingo_luns_martes_mércores_xoves_venres_sábado'.split('_'),
//		  weekdaysShort: 'dom._lun._mar._mér._xov._ven._sáb.'.split('_'),
//		  weekdaysMin: 'do_lu_ma_mé_xo_ve_sá'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D [de] MMMM [de] YYYY',
//			LLL: 'D [de] MMMM [de] YYYY H:mm',
//			LLLL: 'dddd, D [de] MMMM [de] YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: function () {
//			  return '[hoxe ' + (1 !== this.hours() ? 'ás' : 'á') + '] LT'
//			},
//			nextDay: function () {
//			  return '[mañá ' + (1 !== this.hours() ? 'ás' : 'á') + '] LT'
//			},
//			nextWeek: function () {
//			  return 'dddd [' + (1 !== this.hours() ? 'ás' : 'a') + '] LT'
//			},
//			lastDay: function () {
//			  return '[onte ' + (1 !== this.hours() ? 'á' : 'a') + '] LT'
//			},
//			lastWeek: function () {
//			  return '[o] dddd [pasado ' + (1 !== this.hours() ? 'ás' : 'a') + '] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: function (e) {
//			  return 0 === e.indexOf('un') ? 'n' + e : 'en ' + e
//			},
//			past: 'hai %s',
//			s: 'uns segundos',
//			ss: '%d segundos',
//			m: 'un minuto',
//			mm: '%d minutos',
//			h: 'unha hora',
//			hh: '%d horas',
//			d: 'un día',
//			dd: '%d días',
//			M: 'un mes',
//			MM: '%d meses',
//			y: 'un ano',
//			yy: '%d anos'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			s: [
//			  'thodde secondanim',
//			  'thodde second'
//			],
//			ss: [
//			  e + ' secondanim',
//			  e + ' second'
//			],
//			m: [
//			  'eka mintan',
//			  'ek minute'
//			],
//			mm: [
//			  e + ' mintanim',
//			  e + ' mintam'
//			],
//			h: [
//			  'eka horan',
//			  'ek hor'
//			],
//			hh: [
//			  e + ' horanim',
//			  e + ' hor'
//			],
//			d: [
//			  'eka disan',
//			  'ek dis'
//			],
//			dd: [
//			  e + ' disanim',
//			  e + ' dis'
//			],
//			M: [
//			  'eka mhoinean',
//			  'ek mhoino'
//			],
//			MM: [
//			  e + ' mhoineanim',
//			  e + ' mhoine'
//			],
//			y: [
//			  'eka vorsan',
//			  'ek voros'
//			],
//			yy: [
//			  e + ' vorsanim',
//			  e + ' vorsam'
//			]
//		  };
//		  return t ? a[n][0] : a[n][1]
//		}
//		return e.defineLocale('gom-latn', {
//		  months: 'Janer_Febrer_Mars_Abril_Mai_Jun_Julai_Agost_Setembr_Otubr_Novembr_Dezembr'.split('_'),
//		  monthsShort: 'Jan._Feb._Mars_Abr._Mai_Jun_Jul._Ago._Set._Otu._Nov._Dez.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'Aitar_Somar_Mongllar_Budvar_Brestar_Sukrar_Son\'var'.split('_'),
//		  weekdaysShort: 'Ait._Som._Mon._Bud._Bre._Suk._Son.'.split('_'),
//		  weekdaysMin: 'Ai_Sm_Mo_Bu_Br_Su_Sn'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'A h:mm [vazta]',
//			LTS: 'A h:mm:ss [vazta]',
//			L: 'DD-MM-YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY A h:mm [vazta]',
//			LLLL: 'dddd, MMMM[achea] Do, YYYY, A h:mm [vazta]',
//			llll: 'ddd, D MMM YYYY, A h:mm [vazta]'
//		  },
//		  calendar: {
//			sameDay: '[Aiz] LT',
//			nextDay: '[Faleam] LT',
//			nextWeek: '[Ieta to] dddd[,] LT',
//			lastDay: '[Kal] LT',
//			lastWeek: '[Fatlo] dddd[,] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s',
//			past: '%s adim',
//			s: t,
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(er)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'D':
//				return e + 'er';
//			  default:
//			  case 'M':
//			  case 'Q':
//			  case 'DDD':
//			  case 'd':
//			  case 'w':
//			  case 'W':
//				return e
//			}
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  },
//		  meridiemParse: /rati|sokalli|donparam|sanje/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'rati' === t ? e < 4 ? e : e + 12 : 'sokalli' === t ? e : 'donparam' === t ? e > 12 ? e : e + 12 : 'sanje' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'rati' : e < 12 ? 'sokalli' : e < 16 ? 'donparam' : e < 20 ? 'sanje' : 'rati'
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '૧',
//		  2: '૨',
//		  3: '૩',
//		  4: '૪',
//		  5: '૫',
//		  6: '૬',
//		  7: '૭',
//		  8: '૮',
//		  9: '૯',
//		  0: '૦'
//		},
//		n = {
//		  '૧': '1',
//		  '૨': '2',
//		  '૩': '3',
//		  '૪': '4',
//		  '૫': '5',
//		  '૬': '6',
//		  '૭': '7',
//		  '૮': '8',
//		  '૯': '9',
//		  '૦': '0'
//		};
//		return e.defineLocale('gu', {
//		  months: 'જાન્યુઆરી_ફેબ્રુઆરી_માર્ચ_એપ્રિલ_મે_જૂન_જુલાઈ_ઑગસ્ટ_સપ્ટેમ્બર_ઑક્ટ્બર_નવેમ્બર_ડિસેમ્બર'.split('_'),
//		  monthsShort: 'જાન્યુ._ફેબ્રુ._માર્ચ_એપ્રિ._મે_જૂન_જુલા._ઑગ._સપ્ટે._ઑક્ટ્._નવે._ડિસે.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'રવિવાર_સોમવાર_મંગળવાર_બુધ્વાર_ગુરુવાર_શુક્રવાર_શનિવાર'.split('_'),
//		  weekdaysShort: 'રવિ_સોમ_મંગળ_બુધ્_ગુરુ_શુક્ર_શનિ'.split('_'),
//		  weekdaysMin: 'ર_સો_મં_બુ_ગુ_શુ_શ'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm વાગ્યે',
//			LTS: 'A h:mm:ss વાગ્યે',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm વાગ્યે',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm વાગ્યે'
//		  },
//		  calendar: {
//			sameDay: '[આજ] LT',
//			nextDay: '[કાલે] LT',
//			nextWeek: 'dddd, LT',
//			lastDay: '[ગઇકાલે] LT',
//			lastWeek: '[પાછલા] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s મા',
//			past: '%s પેહલા',
//			s: 'અમુક પળો',
//			ss: '%d સેકંડ',
//			m: 'એક મિનિટ',
//			mm: '%d મિનિટ',
//			h: 'એક કલાક',
//			hh: '%d કલાક',
//			d: 'એક દિવસ',
//			dd: '%d દિવસ',
//			M: 'એક મહિનો',
//			MM: '%d મહિનો',
//			y: 'એક વર્ષ',
//			yy: '%d વર્ષ'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[૧૨૩૪૫૬૭૮૯૦]/g, function (e) {
//			  return n[e]
//			})
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			})
//		  },
//		  meridiemParse: /રાત|બપોર|સવાર|સાંજ/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'રાત' === t ? e < 4 ? e : e + 12 : 'સવાર' === t ? e : 'બપોર' === t ? e >= 10 ? e : e + 12 : 'સાંજ' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'રાત' : e < 10 ? 'સવાર' : e < 17 ? 'બપોર' : e < 20 ? 'સાંજ' : 'રાત'
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('he', {
//		  months: 'ינואר_פברואר_מרץ_אפריל_מאי_יוני_יולי_אוגוסט_ספטמבר_אוקטובר_נובמבר_דצמבר'.split('_'),
//		  monthsShort: 'ינו׳_פבר׳_מרץ_אפר׳_מאי_יוני_יולי_אוג׳_ספט׳_אוק׳_נוב׳_דצמ׳'.split('_'),
//		  weekdays: 'ראשון_שני_שלישי_רביעי_חמישי_שישי_שבת'.split('_'),
//		  weekdaysShort: 'א׳_ב׳_ג׳_ד׳_ה׳_ו׳_ש׳'.split('_'),
//		  weekdaysMin: 'א_ב_ג_ד_ה_ו_ש'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D [ב]MMMM YYYY',
//			LLL: 'D [ב]MMMM YYYY HH:mm',
//			LLLL: 'dddd, D [ב]MMMM YYYY HH:mm',
//			l: 'D/M/YYYY',
//			ll: 'D MMM YYYY',
//			lll: 'D MMM YYYY HH:mm',
//			llll: 'ddd, D MMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[היום ב־]LT',
//			nextDay: '[מחר ב־]LT',
//			nextWeek: 'dddd [בשעה] LT',
//			lastDay: '[אתמול ב־]LT',
//			lastWeek: '[ביום] dddd [האחרון בשעה] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'בעוד %s',
//			past: 'לפני %s',
//			s: 'מספר שניות',
//			ss: '%d שניות',
//			m: 'דקה',
//			mm: '%d דקות',
//			h: 'שעה',
//			hh: function (e) {
//			  return 2 === e ? 'שעתיים' : e + ' שעות'
//			},
//			d: 'יום',
//			dd: function (e) {
//			  return 2 === e ? 'יומיים' : e + ' ימים'
//			},
//			M: 'חודש',
//			MM: function (e) {
//			  return 2 === e ? 'חודשיים' : e + ' חודשים'
//			},
//			y: 'שנה',
//			yy: function (e) {
//			  return 2 === e ? 'שנתיים' : e % 10 == 0 && 10 !== e ? e + ' שנה' : e + ' שנים'
//			}
//		  },
//		  meridiemParse: /אחה"צ|לפנה"צ|אחרי הצהריים|לפני הצהריים|לפנות בוקר|בבוקר|בערב/i,
//		  isPM: function (e) {
//			return /^(אחה"צ|אחרי הצהריים|בערב)$/.test(e)
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 5 ? 'לפנות בוקר' : e < 10 ? 'בבוקר' : e < 12 ? n ? 'לפנה"צ' : 'לפני הצהריים' : e < 18 ? n ? 'אחה"צ' : 'אחרי הצהריים' : 'בערב'
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '१',
//		  2: '२',
//		  3: '३',
//		  4: '४',
//		  5: '५',
//		  6: '६',
//		  7: '७',
//		  8: '८',
//		  9: '९',
//		  0: '०'
//		},
//		n = {
//		  '१': '1',
//		  '२': '2',
//		  '३': '3',
//		  '४': '4',
//		  '५': '5',
//		  '६': '6',
//		  '७': '7',
//		  '८': '8',
//		  '९': '9',
//		  '०': '0'
//		};
//		return e.defineLocale('hi', {
//		  months: 'जनवरी_फ़रवरी_मार्च_अप्रैल_मई_जून_जुलाई_अगस्त_सितम्बर_अक्टूबर_नवम्बर_दिसम्बर'.split('_'),
//		  monthsShort: 'जन._फ़र._मार्च_अप्रै._मई_जून_जुल._अग._सित._अक्टू._नव._दिस.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'रविवार_सोमवार_मंगलवार_बुधवार_गुरूवार_शुक्रवार_शनिवार'.split('_'),
//		  weekdaysShort: 'रवि_सोम_मंगल_बुध_गुरू_शुक्र_शनि'.split('_'),
//		  weekdaysMin: 'र_सो_मं_बु_गु_शु_श'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm बजे',
//			LTS: 'A h:mm:ss बजे',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm बजे',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm बजे'
//		  },
//		  calendar: {
//			sameDay: '[आज] LT',
//			nextDay: '[कल] LT',
//			nextWeek: 'dddd, LT',
//			lastDay: '[कल] LT',
//			lastWeek: '[पिछले] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s में',
//			past: '%s पहले',
//			s: 'कुछ ही क्षण',
//			ss: '%d सेकंड',
//			m: 'एक मिनट',
//			mm: '%d मिनट',
//			h: 'एक घंटा',
//			hh: '%d घंटे',
//			d: 'एक दिन',
//			dd: '%d दिन',
//			M: 'एक महीने',
//			MM: '%d महीने',
//			y: 'एक वर्ष',
//			yy: '%d वर्ष'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[१२३४५६७८९०]/g, function (e) {
//			  return n[e]
//			})
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			})
//		  },
//		  meridiemParse: /रात|सुबह|दोपहर|शाम/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'रात' === t ? e < 4 ? e : e + 12 : 'सुबह' === t ? e : 'दोपहर' === t ? e >= 10 ? e : e + 12 : 'शाम' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'रात' : e < 10 ? 'सुबह' : e < 17 ? 'दोपहर' : e < 20 ? 'शाम' : 'रात'
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n) {
//		  var r = e + ' ';
//		  switch (n) {
//			case 'ss':
//			  return r += 1 === e ? 'sekunda' : 2 === e || 3 === e || 4 === e ? 'sekunde' : 'sekundi';
//			case 'm':
//			  return t ? 'jedna minuta' : 'jedne minute';
//			case 'mm':
//			  return r += 1 === e ? 'minuta' : 2 === e || 3 === e || 4 === e ? 'minute' : 'minuta';
//			case 'h':
//			  return t ? 'jedan sat' : 'jednog sata';
//			case 'hh':
//			  return r += 1 === e ? 'sat' : 2 === e || 3 === e || 4 === e ? 'sata' : 'sati';
//			case 'dd':
//			  return r += 1 === e ? 'dan' : 'dana';
//			case 'MM':
//			  return r += 1 === e ? 'mjesec' : 2 === e || 3 === e || 4 === e ? 'mjeseca' : 'mjeseci';
//			case 'yy':
//			  return r += 1 === e ? 'godina' : 2 === e || 3 === e || 4 === e ? 'godine' : 'godina'
//		  }
//		}
//		return e.defineLocale('hr', {
//		  months: {
//			format: 'siječnja_veljače_ožujka_travnja_svibnja_lipnja_srpnja_kolovoza_rujna_listopada_studenoga_prosinca'.split('_'),
//			standalone: 'siječanj_veljača_ožujak_travanj_svibanj_lipanj_srpanj_kolovoz_rujan_listopad_studeni_prosinac'.split('_')
//		  },
//		  monthsShort: 'sij._velj._ožu._tra._svi._lip._srp._kol._ruj._lis._stu._pro.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'nedjelja_ponedjeljak_utorak_srijeda_četvrtak_petak_subota'.split('_'),
//		  weekdaysShort: 'ned._pon._uto._sri._čet._pet._sub.'.split('_'),
//		  weekdaysMin: 'ne_po_ut_sr_če_pe_su'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm',
//			LLLL: 'dddd, D. MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[danas u] LT',
//			nextDay: '[sutra u] LT',
//			nextWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[u] [nedjelju] [u] LT';
//				case 3:
//				  return '[u] [srijedu] [u] LT';
//				case 6:
//				  return '[u] [subotu] [u] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[u] dddd [u] LT'
//			  }
//			},
//			lastDay: '[jučer u] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				case 3:
//				  return '[prošlu] dddd [u] LT';
//				case 6:
//				  return '[prošle] [subote] [u] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[prošli] dddd [u] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'za %s',
//			past: 'prije %s',
//			s: 'par sekundi',
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: 'dan',
//			dd: t,
//			M: 'mjesec',
//			MM: t,
//			y: 'godinu',
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = e;
//		  switch (n) {
//			case 's':
//			  return r || t ? 'néhány másodperc' : 'néhány másodperce';
//			case 'ss':
//			  return a + (r || t) ? ' másodperc' : ' másodperce';
//			case 'm':
//			  return 'egy' + (r || t ? ' perc' : ' perce');
//			case 'mm':
//			  return a + (r || t ? ' perc' : ' perce');
//			case 'h':
//			  return 'egy' + (r || t ? ' óra' : ' órája');
//			case 'hh':
//			  return a + (r || t ? ' óra' : ' órája');
//			case 'd':
//			  return 'egy' + (r || t ? ' nap' : ' napja');
//			case 'dd':
//			  return a + (r || t ? ' nap' : ' napja');
//			case 'M':
//			  return 'egy' + (r || t ? ' hónap' : ' hónapja');
//			case 'MM':
//			  return a + (r || t ? ' hónap' : ' hónapja');
//			case 'y':
//			  return 'egy' + (r || t ? ' év' : ' éve');
//			case 'yy':
//			  return a + (r || t ? ' év' : ' éve')
//		  }
//		  return ''
//		}
//		function n(e) {
//		  return (e ? '' : '[múlt] ') + '[' + r[this.day()] + '] LT[-kor]'
//		}
//		var r = 'vasárnap hétfőn kedden szerdán csütörtökön pénteken szombaton'.split(' ');
//		return e.defineLocale('hu', {
//		  months: 'január_február_március_április_május_június_július_augusztus_szeptember_október_november_december'.split('_'),
//		  monthsShort: 'jan_feb_márc_ápr_máj_jún_júl_aug_szept_okt_nov_dec'.split('_'),
//		  weekdays: 'vasárnap_hétfő_kedd_szerda_csütörtök_péntek_szombat'.split('_'),
//		  weekdaysShort: 'vas_hét_kedd_sze_csüt_pén_szo'.split('_'),
//		  weekdaysMin: 'v_h_k_sze_cs_p_szo'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'YYYY.MM.DD.',
//			LL: 'YYYY. MMMM D.',
//			LLL: 'YYYY. MMMM D. H:mm',
//			LLLL: 'YYYY. MMMM D., dddd H:mm'
//		  },
//		  meridiemParse: /de|du/i,
//		  isPM: function (e) {
//			return 'u' === e.charAt(1).toLowerCase()
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? !0 === n ? 'de' : 'DE' : !0 === n ? 'du' : 'DU'
//		  },
//		  calendar: {
//			sameDay: '[ma] LT[-kor]',
//			nextDay: '[holnap] LT[-kor]',
//			nextWeek: function () {
//			  return n.call(this, !0)
//			},
//			lastDay: '[tegnap] LT[-kor]',
//			lastWeek: function () {
//			  return n.call(this, !1)
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s múlva',
//			past: '%s',
//			s: t,
//			ss: t,
//			m: t,
//			mm: t,
//			h: t,
//			hh: t,
//			d: t,
//			dd: t,
//			M: t,
//			MM: t,
//			y: t,
//			yy: t
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('hy-am', {
//		  months: {
//			format: 'հունվարի_փետրվարի_մարտի_ապրիլի_մայիսի_հունիսի_հուլիսի_օգոստոսի_սեպտեմբերի_հոկտեմբերի_նոյեմբերի_դեկտեմբերի'.split('_'),
//			standalone: 'հունվար_փետրվար_մարտ_ապրիլ_մայիս_հունիս_հուլիս_օգոստոս_սեպտեմբեր_հոկտեմբեր_նոյեմբեր_դեկտեմբեր'.split('_')
//		  },
//		  monthsShort: 'հնվ_փտր_մրտ_ապր_մյս_հնս_հլս_օգս_սպտ_հկտ_նմբ_դկտ'.split('_'),
//		  weekdays: 'կիրակի_երկուշաբթի_երեքշաբթի_չորեքշաբթի_հինգշաբթի_ուրբաթ_շաբաթ'.split('_'),
//		  weekdaysShort: 'կրկ_երկ_երք_չրք_հնգ_ուրբ_շբթ'.split('_'),
//		  weekdaysMin: 'կրկ_երկ_երք_չրք_հնգ_ուրբ_շբթ'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY թ.',
//			LLL: 'D MMMM YYYY թ., HH:mm',
//			LLLL: 'dddd, D MMMM YYYY թ., HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[այսօր] LT',
//			nextDay: '[վաղը] LT',
//			lastDay: '[երեկ] LT',
//			nextWeek: function () {
//			  return 'dddd [օրը ժամը] LT'
//			},
//			lastWeek: function () {
//			  return '[անցած] dddd [օրը ժամը] LT'
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s հետո',
//			past: '%s առաջ',
//			s: 'մի քանի վայրկյան',
//			ss: '%d վայրկյան',
//			m: 'րոպե',
//			mm: '%d րոպե',
//			h: 'ժամ',
//			hh: '%d ժամ',
//			d: 'օր',
//			dd: '%d օր',
//			M: 'ամիս',
//			MM: '%d ամիս',
//			y: 'տարի',
//			yy: '%d տարի'
//		  },
//		  meridiemParse: /գիշերվա|առավոտվա|ցերեկվա|երեկոյան/,
//		  isPM: function (e) {
//			return /^(ցերեկվա|երեկոյան)$/.test(e)
//		  },
//		  meridiem: function (e) {
//			return e < 4 ? 'գիշերվա' : e < 12 ? 'առավոտվա' : e < 17 ? 'ցերեկվա' : 'երեկոյան'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}|\d{1,2}-(ին|րդ)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'DDD':
//			  case 'w':
//			  case 'W':
//			  case 'DDDo':
//				return 1 === e ? e + '-ին' : e + '-րդ';
//			  default:
//				return e
//			}
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('id', {
//		  months: 'Januari_Februari_Maret_April_Mei_Juni_Juli_Agustus_September_Oktober_November_Desember'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_Mei_Jun_Jul_Ags_Sep_Okt_Nov_Des'.split('_'),
//		  weekdays: 'Minggu_Senin_Selasa_Rabu_Kamis_Jumat_Sabtu'.split('_'),
//		  weekdaysShort: 'Min_Sen_Sel_Rab_Kam_Jum_Sab'.split('_'),
//		  weekdaysMin: 'Mg_Sn_Sl_Rb_Km_Jm_Sb'.split('_'),
//		  longDateFormat: {
//			LT: 'HH.mm',
//			LTS: 'HH.mm.ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY [pukul] HH.mm',
//			LLLL: 'dddd, D MMMM YYYY [pukul] HH.mm'
//		  },
//		  meridiemParse: /pagi|siang|sore|malam/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'pagi' === t ? e : 'siang' === t ? e >= 11 ? e : e + 12 : 'sore' === t || 'malam' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 11 ? 'pagi' : e < 15 ? 'siang' : e < 19 ? 'sore' : 'malam'
//		  },
//		  calendar: {
//			sameDay: '[Hari ini pukul] LT',
//			nextDay: '[Besok pukul] LT',
//			nextWeek: 'dddd [pukul] LT',
//			lastDay: '[Kemarin pukul] LT',
//			lastWeek: 'dddd [lalu pukul] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'dalam %s',
//			past: '%s yang lalu',
//			s: 'beberapa detik',
//			ss: '%d detik',
//			m: 'semenit',
//			mm: '%d menit',
//			h: 'sejam',
//			hh: '%d jam',
//			d: 'sehari',
//			dd: '%d hari',
//			M: 'sebulan',
//			MM: '%d bulan',
//			y: 'setahun',
//			yy: '%d tahun'
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e) {
//		  return e % 100 == 11 || e % 10 != 1
//		}
//		function n(e, n, r, a) {
//		  var o = e + ' ';
//		  switch (r) {
//			case 's':
//			  return n || a ? 'nokkrar sekúndur' : 'nokkrum sekúndum';
//			case 'ss':
//			  return t(e) ? o + (n || a ? 'sekúndur' : 'sekúndum')  : o + 'sekúnda';
//			case 'm':
//			  return n ? 'mínúta' : 'mínútu';
//			case 'mm':
//			  return t(e) ? o + (n || a ? 'mínútur' : 'mínútum')  : n ? o + 'mínúta' : o + 'mínútu';
//			case 'hh':
//			  return t(e) ? o + (n || a ? 'klukkustundir' : 'klukkustundum')  : o + 'klukkustund';
//			case 'd':
//			  return n ? 'dagur' : a ? 'dag' : 'degi';
//			case 'dd':
//			  return t(e) ? n ? o + 'dagar' : o + (a ? 'daga' : 'dögum')  : n ? o + 'dagur' : o + (a ? 'dag' : 'degi');
//			case 'M':
//			  return n ? 'mánuður' : a ? 'mánuð' : 'mánuði';
//			case 'MM':
//			  return t(e) ? n ? o + 'mánuðir' : o + (a ? 'mánuði' : 'mánuðum')  : n ? o + 'mánuður' : o + (a ? 'mánuð' : 'mánuði');
//			case 'y':
//			  return n || a ? 'ár' : 'ári';
//			case 'yy':
//			  return t(e) ? o + (n || a ? 'ár' : 'árum')  : o + (n || a ? 'ár' : 'ári')
//		  }
//		}
//		return e.defineLocale('is', {
//		  months: 'janúar_febrúar_mars_apríl_maí_júní_júlí_ágúst_september_október_nóvember_desember'.split('_'),
//		  monthsShort: 'jan_feb_mar_apr_maí_jún_júl_ágú_sep_okt_nóv_des'.split('_'),
//		  weekdays: 'sunnudagur_mánudagur_þriðjudagur_miðvikudagur_fimmtudagur_föstudagur_laugardagur'.split('_'),
//		  weekdaysShort: 'sun_mán_þri_mið_fim_fös_lau'.split('_'),
//		  weekdaysMin: 'Su_Má_Þr_Mi_Fi_Fö_La'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY [kl.] H:mm',
//			LLLL: 'dddd, D. MMMM YYYY [kl.] H:mm'
//		  },
//		  calendar: {
//			sameDay: '[í dag kl.] LT',
//			nextDay: '[á morgun kl.] LT',
//			nextWeek: 'dddd [kl.] LT',
//			lastDay: '[í gær kl.] LT',
//			lastWeek: '[síðasta] dddd [kl.] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'eftir %s',
//			past: 'fyrir %s síðan',
//			s: n,
//			ss: n,
//			m: n,
//			mm: n,
//			h: 'klukkustund',
//			hh: n,
//			d: n,
//			dd: n,
//			M: n,
//			MM: n,
//			y: n,
//			yy: n
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('it', {
//		  months: 'gennaio_febbraio_marzo_aprile_maggio_giugno_luglio_agosto_settembre_ottobre_novembre_dicembre'.split('_'),
//		  monthsShort: 'gen_feb_mar_apr_mag_giu_lug_ago_set_ott_nov_dic'.split('_'),
//		  weekdays: 'domenica_lunedì_martedì_mercoledì_giovedì_venerdì_sabato'.split('_'),
//		  weekdaysShort: 'dom_lun_mar_mer_gio_ven_sab'.split('_'),
//		  weekdaysMin: 'do_lu_ma_me_gi_ve_sa'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Oggi alle] LT',
//			nextDay: '[Domani alle] LT',
//			nextWeek: 'dddd [alle] LT',
//			lastDay: '[Ieri alle] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[la scorsa] dddd [alle] LT';
//				default:
//				  return '[lo scorso] dddd [alle] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: function (e) {
//			  return (/^[0-9].+$/.test(e) ? 'tra' : 'in') + ' ' + e
//			},
//			past: '%s fa',
//			s: 'alcuni secondi',
//			ss: '%d secondi',
//			m: 'un minuto',
//			mm: '%d minuti',
//			h: 'un\'ora',
//			hh: '%d ore',
//			d: 'un giorno',
//			dd: '%d giorni',
//			M: 'un mese',
//			MM: '%d mesi',
//			y: 'un anno',
//			yy: '%d anni'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ja', {
//		  months: '1月_2月_3月_4月_5月_6月_7月_8月_9月_10月_11月_12月'.split('_'),
//		  monthsShort: '1月_2月_3月_4月_5月_6月_7月_8月_9月_10月_11月_12月'.split('_'),
//		  weekdays: '日曜日_月曜日_火曜日_水曜日_木曜日_金曜日_土曜日'.split('_'),
//		  weekdaysShort: '日_月_火_水_木_金_土'.split('_'),
//		  weekdaysMin: '日_月_火_水_木_金_土'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'YYYY/MM/DD',
//			LL: 'YYYY年M月D日',
//			LLL: 'YYYY年M月D日 HH:mm',
//			LLLL: 'YYYY年M月D日 HH:mm dddd',
//			l: 'YYYY/MM/DD',
//			ll: 'YYYY年M月D日',
//			lll: 'YYYY年M月D日 HH:mm',
//			llll: 'YYYY年M月D日 HH:mm dddd'
//		  },
//		  meridiemParse: /午前|午後/i,
//		  isPM: function (e) {
//			return '午後' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? '午前' : '午後'
//		  },
//		  calendar: {
//			sameDay: '[今日] LT',
//			nextDay: '[明日] LT',
//			nextWeek: '[来週]dddd LT',
//			lastDay: '[昨日] LT',
//			lastWeek: '[前週]dddd LT',
//			sameElse: 'L'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}日/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'd':
//			  case 'D':
//			  case 'DDD':
//				return e + '日';
//			  default:
//				return e
//			}
//		  },
//		  relativeTime: {
//			future: '%s後',
//			past: '%s前',
//			s: '数秒',
//			ss: '%d秒',
//			m: '1分',
//			mm: '%d分',
//			h: '1時間',
//			hh: '%d時間',
//			d: '1日',
//			dd: '%d日',
//			M: '1ヶ月',
//			MM: '%dヶ月',
//			y: '1年',
//			yy: '%d年'
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('jv', {
//		  months: 'Januari_Februari_Maret_April_Mei_Juni_Juli_Agustus_September_Oktober_Nopember_Desember'.split('_'),
//		  monthsShort: 'Jan_Feb_Mar_Apr_Mei_Jun_Jul_Ags_Sep_Okt_Nop_Des'.split('_'),
//		  weekdays: 'Minggu_Senen_Seloso_Rebu_Kemis_Jemuwah_Septu'.split('_'),
//		  weekdaysShort: 'Min_Sen_Sel_Reb_Kem_Jem_Sep'.split('_'),
//		  weekdaysMin: 'Mg_Sn_Sl_Rb_Km_Jm_Sp'.split('_'),
//		  longDateFormat: {
//			LT: 'HH.mm',
//			LTS: 'HH.mm.ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY [pukul] HH.mm',
//			LLLL: 'dddd, D MMMM YYYY [pukul] HH.mm'
//		  },
//		  meridiemParse: /enjing|siyang|sonten|ndalu/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'enjing' === t ? e : 'siyang' === t ? e >= 11 ? e : e + 12 : 'sonten' === t || 'ndalu' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 11 ? 'enjing' : e < 15 ? 'siyang' : e < 19 ? 'sonten' : 'ndalu'
//		  },
//		  calendar: {
//			sameDay: '[Dinten puniko pukul] LT',
//			nextDay: '[Mbenjang pukul] LT',
//			nextWeek: 'dddd [pukul] LT',
//			lastDay: '[Kala wingi pukul] LT',
//			lastWeek: 'dddd [kepengker pukul] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'wonten ing %s',
//			past: '%s ingkang kepengker',
//			s: 'sawetawis detik',
//			ss: '%d detik',
//			m: 'setunggal menit',
//			mm: '%d menit',
//			h: 'setunggal jam',
//			hh: '%d jam',
//			d: 'sedinten',
//			dd: '%d dinten',
//			M: 'sewulan',
//			MM: '%d wulan',
//			y: 'setaun',
//			yy: '%d taun'
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ka', {
//		  months: {
//			standalone: 'იანვარი_თებერვალი_მარტი_აპრილი_მაისი_ივნისი_ივლისი_აგვისტო_სექტემბერი_ოქტომბერი_ნოემბერი_დეკემბერი'.split('_'),
//			format: 'იანვარს_თებერვალს_მარტს_აპრილის_მაისს_ივნისს_ივლისს_აგვისტს_სექტემბერს_ოქტომბერს_ნოემბერს_დეკემბერს'.split('_')
//		  },
//		  monthsShort: 'იან_თებ_მარ_აპრ_მაი_ივნ_ივლ_აგვ_სექ_ოქტ_ნოე_დეკ'.split('_'),
//		  weekdays: {
//			standalone: 'კვირა_ორშაბათი_სამშაბათი_ოთხშაბათი_ხუთშაბათი_პარასკევი_შაბათი'.split('_'),
//			format: 'კვირას_ორშაბათს_სამშაბათს_ოთხშაბათს_ხუთშაბათს_პარასკევს_შაბათს'.split('_'),
//			isFormat: /(წინა|შემდეგ)/
//		  },
//		  weekdaysShort: 'კვი_ორშ_სამ_ოთხ_ხუთ_პარ_შაბ'.split('_'),
//		  weekdaysMin: 'კვ_ორ_სა_ოთ_ხუ_პა_შა'.split('_'),
//		  longDateFormat: {
//			LT: 'h:mm A',
//			LTS: 'h:mm:ss A',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY h:mm A',
//			LLLL: 'dddd, D MMMM YYYY h:mm A'
//		  },
//		  calendar: {
//			sameDay: '[დღეს] LT[-ზე]',
//			nextDay: '[ხვალ] LT[-ზე]',
//			lastDay: '[გუშინ] LT[-ზე]',
//			nextWeek: '[შემდეგ] dddd LT[-ზე]',
//			lastWeek: '[წინა] dddd LT-ზე',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: function (e) {
//			  return /(წამი|წუთი|საათი|წელი)/.test(e) ? e.replace(/ი$/, 'ში')  : e + 'ში'
//			},
//			past: function (e) {
//			  return /(წამი|წუთი|საათი|დღე|თვე)/.test(e) ? e.replace(/(ი|ე)$/, 'ის უკან')  : /წელი/.test(e) ? e.replace(/წელი$/, 'წლის უკან')  : void 0
//			},
//			s: 'რამდენიმე წამი',
//			ss: '%d წამი',
//			m: 'წუთი',
//			mm: '%d წუთი',
//			h: 'საათი',
//			hh: '%d საათი',
//			d: 'დღე',
//			dd: '%d დღე',
//			M: 'თვე',
//			MM: '%d თვე',
//			y: 'წელი',
//			yy: '%d წელი'
//		  },
//		  dayOfMonthOrdinalParse: /0|1-ლი|მე-\d{1,2}|\d{1,2}-ე/,
//		  ordinal: function (e) {
//			return 0 === e ? e : 1 === e ? e + '-ლი' : e < 20 || e <= 100 && e % 20 == 0 || e % 100 == 0 ? 'მე-' + e : e + '-ე'
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  0: '-ші',
//		  1: '-ші',
//		  2: '-ші',
//		  3: '-ші',
//		  4: '-ші',
//		  5: '-ші',
//		  6: '-шы',
//		  7: '-ші',
//		  8: '-ші',
//		  9: '-шы',
//		  10: '-шы',
//		  20: '-шы',
//		  30: '-шы',
//		  40: '-шы',
//		  50: '-ші',
//		  60: '-шы',
//		  70: '-ші',
//		  80: '-ші',
//		  90: '-шы',
//		  100: '-ші'
//		};
//		return e.defineLocale('kk', {
//		  months: 'қаңтар_ақпан_наурыз_сәуір_мамыр_маусым_шілде_тамыз_қыркүйек_қазан_қараша_желтоқсан'.split('_'),
//		  monthsShort: 'қаң_ақп_нау_сәу_мам_мау_шіл_там_қыр_қаз_қар_жел'.split('_'),
//		  weekdays: 'жексенбі_дүйсенбі_сейсенбі_сәрсенбі_бейсенбі_жұма_сенбі'.split('_'),
//		  weekdaysShort: 'жек_дүй_сей_сәр_бей_жұм_сен'.split('_'),
//		  weekdaysMin: 'жк_дй_сй_ср_бй_жм_сн'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Бүгін сағат] LT',
//			nextDay: '[Ертең сағат] LT',
//			nextWeek: 'dddd [сағат] LT',
//			lastDay: '[Кеше сағат] LT',
//			lastWeek: '[Өткен аптаның] dddd [сағат] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s ішінде',
//			past: '%s бұрын',
//			s: 'бірнеше секунд',
//			ss: '%d секунд',
//			m: 'бір минут',
//			mm: '%d минут',
//			h: 'бір сағат',
//			hh: '%d сағат',
//			d: 'бір күн',
//			dd: '%d күн',
//			M: 'бір ай',
//			MM: '%d ай',
//			y: 'бір жыл',
//			yy: '%d жыл'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(ші|шы)/,
//		  ordinal: function (e) {
//			var n = e % 10,
//			r = e >= 100 ? 100 : null;
//			return e + (t[e] || t[n] || t[r])
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('km', {
//		  months: 'មករា_កុម្ភៈ_មីនា_មេសា_ឧសភា_មិថុនា_កក្កដា_សីហា_កញ្ញា_តុលា_វិច្ឆិកា_ធ្នូ'.split('_'),
//		  monthsShort: 'មករា_កុម្ភៈ_មីនា_មេសា_ឧសភា_មិថុនា_កក្កដា_សីហា_កញ្ញា_តុលា_វិច្ឆិកា_ធ្នូ'.split('_'),
//		  weekdays: 'អាទិត្យ_ច័ន្ទ_អង្គារ_ពុធ_ព្រហស្បតិ៍_សុក្រ_សៅរ៍'.split('_'),
//		  weekdaysShort: 'អាទិត្យ_ច័ន្ទ_អង្គារ_ពុធ_ព្រហស្បតិ៍_សុក្រ_សៅរ៍'.split('_'),
//		  weekdaysMin: 'អាទិត្យ_ច័ន្ទ_អង្គារ_ពុធ_ព្រហស្បតិ៍_សុក្រ_សៅរ៍'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[ថ្ងៃនេះ ម៉ោង] LT',
//			nextDay: '[ស្អែក ម៉ោង] LT',
//			nextWeek: 'dddd [ម៉ោង] LT',
//			lastDay: '[ម្សិលមិញ ម៉ោង] LT',
//			lastWeek: 'dddd [សប្តាហ៍មុន] [ម៉ោង] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%sទៀត',
//			past: '%sមុន',
//			s: 'ប៉ុន្មានវិនាទី',
//			ss: '%d វិនាទី',
//			m: 'មួយនាទី',
//			mm: '%d នាទី',
//			h: 'មួយម៉ោង',
//			hh: '%d ម៉ោង',
//			d: 'មួយថ្ងៃ',
//			dd: '%d ថ្ងៃ',
//			M: 'មួយខែ',
//			MM: '%d ខែ',
//			y: 'មួយឆ្នាំ',
//			yy: '%d ឆ្នាំ'
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  1: '೧',
//		  2: '೨',
//		  3: '೩',
//		  4: '೪',
//		  5: '೫',
//		  6: '೬',
//		  7: '೭',
//		  8: '೮',
//		  9: '೯',
//		  0: '೦'
//		},
//		n = {
//		  '೧': '1',
//		  '೨': '2',
//		  '೩': '3',
//		  '೪': '4',
//		  '೫': '5',
//		  '೬': '6',
//		  '೭': '7',
//		  '೮': '8',
//		  '೯': '9',
//		  '೦': '0'
//		};
//		return e.defineLocale('kn', {
//		  months: 'ಜನವರಿ_ಫೆಬ್ರವರಿ_ಮಾರ್ಚ್_ಏಪ್ರಿಲ್_ಮೇ_ಜೂನ್_ಜುಲೈ_ಆಗಸ್ಟ್_ಸೆಪ್ಟೆಂಬರ್_ಅಕ್ಟೋಬರ್_ನವೆಂಬರ್_ಡಿಸೆಂಬರ್'.split('_'),
//		  monthsShort: 'ಜನ_ಫೆಬ್ರ_ಮಾರ್ಚ್_ಏಪ್ರಿಲ್_ಮೇ_ಜೂನ್_ಜುಲೈ_ಆಗಸ್ಟ್_ಸೆಪ್ಟೆಂಬ_ಅಕ್ಟೋಬ_ನವೆಂಬ_ಡಿಸೆಂಬ'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'ಭಾನುವಾರ_ಸೋಮವಾರ_ಮಂಗಳವಾರ_ಬುಧವಾರ_ಗುರುವಾರ_ಶುಕ್ರವಾರ_ಶನಿವಾರ'.split('_'),
//		  weekdaysShort: 'ಭಾನು_ಸೋಮ_ಮಂಗಳ_ಬುಧ_ಗುರು_ಶುಕ್ರ_ಶನಿ'.split('_'),
//		  weekdaysMin: 'ಭಾ_ಸೋ_ಮಂ_ಬು_ಗು_ಶು_ಶ'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm',
//			LTS: 'A h:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm'
//		  },
//		  calendar: {
//			sameDay: '[ಇಂದು] LT',
//			nextDay: '[ನಾಳೆ] LT',
//			nextWeek: 'dddd, LT',
//			lastDay: '[ನಿನ್ನೆ] LT',
//			lastWeek: '[ಕೊನೆಯ] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s ನಂತರ',
//			past: '%s ಹಿಂದೆ',
//			s: 'ಕೆಲವು ಕ್ಷಣಗಳು',
//			ss: '%d ಸೆಕೆಂಡುಗಳು',
//			m: 'ಒಂದು ನಿಮಿಷ',
//			mm: '%d ನಿಮಿಷ',
//			h: 'ಒಂದು ಗಂಟೆ',
//			hh: '%d ಗಂಟೆ',
//			d: 'ಒಂದು ದಿನ',
//			dd: '%d ದಿನ',
//			M: 'ಒಂದು ತಿಂಗಳು',
//			MM: '%d ತಿಂಗಳು',
//			y: 'ಒಂದು ವರ್ಷ',
//			yy: '%d ವರ್ಷ'
//		  },
//		  preparse: function (e) {
//			return e.replace(/[೧೨೩೪೫೬೭೮೯೦]/g, function (e) {
//			  return n[e]
//			})
//		  },
//		  postformat: function (e) {
//			return e.replace(/\d/g, function (e) {
//			  return t[e]
//			})
//		  },
//		  meridiemParse: /ರಾತ್ರಿ|ಬೆಳಿಗ್ಗೆ|ಮಧ್ಯಾಹ್ನ|ಸಂಜೆ/,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'ರಾತ್ರಿ' === t ? e < 4 ? e : e + 12 : 'ಬೆಳಿಗ್ಗೆ' === t ? e : 'ಮಧ್ಯಾಹ್ನ' === t ? e >= 10 ? e : e + 12 : 'ಸಂಜೆ' === t ? e + 12 : void 0
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'ರಾತ್ರಿ' : e < 10 ? 'ಬೆಳಿಗ್ಗೆ' : e < 17 ? 'ಮಧ್ಯಾಹ್ನ' : e < 20 ? 'ಸಂಜೆ' : 'ರಾತ್ರಿ'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(ನೇ)/,
//		  ordinal: function (e) {
//			return e + 'ನೇ'
//		  },
//		  week: {
//			dow: 0,
//			doy: 6
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ko', {
//		  months: '1월_2월_3월_4월_5월_6월_7월_8월_9월_10월_11월_12월'.split('_'),
//		  monthsShort: '1월_2월_3월_4월_5월_6월_7월_8월_9월_10월_11월_12월'.split('_'),
//		  weekdays: '일요일_월요일_화요일_수요일_목요일_금요일_토요일'.split('_'),
//		  weekdaysShort: '일_월_화_수_목_금_토'.split('_'),
//		  weekdaysMin: '일_월_화_수_목_금_토'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm',
//			LTS: 'A h:mm:ss',
//			L: 'YYYY.MM.DD',
//			LL: 'YYYY년 MMMM D일',
//			LLL: 'YYYY년 MMMM D일 A h:mm',
//			LLLL: 'YYYY년 MMMM D일 dddd A h:mm',
//			l: 'YYYY.MM.DD',
//			ll: 'YYYY년 MMMM D일',
//			lll: 'YYYY년 MMMM D일 A h:mm',
//			llll: 'YYYY년 MMMM D일 dddd A h:mm'
//		  },
//		  calendar: {
//			sameDay: '오늘 LT',
//			nextDay: '내일 LT',
//			nextWeek: 'dddd LT',
//			lastDay: '어제 LT',
//			lastWeek: '지난주 dddd LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s 후',
//			past: '%s 전',
//			s: '몇 초',
//			ss: '%d초',
//			m: '1분',
//			mm: '%d분',
//			h: '한 시간',
//			hh: '%d시간',
//			d: '하루',
//			dd: '%d일',
//			M: '한 달',
//			MM: '%d달',
//			y: '일 년',
//			yy: '%d년'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}(일|월|주)/,
//		  ordinal: function (e, t) {
//			switch (t) {
//			  case 'd':
//			  case 'D':
//			  case 'DDD':
//				return e + '일';
//			  case 'M':
//				return e + '월';
//			  case 'w':
//			  case 'W':
//				return e + '주';
//			  default:
//				return e
//			}
//		  },
//		  meridiemParse: /오전|오후/,
//		  isPM: function (e) {
//			return '오후' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? '오전' : '오후'
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  0: '-чү',
//		  1: '-чи',
//		  2: '-чи',
//		  3: '-чү',
//		  4: '-чү',
//		  5: '-чи',
//		  6: '-чы',
//		  7: '-чи',
//		  8: '-чи',
//		  9: '-чу',
//		  10: '-чу',
//		  20: '-чы',
//		  30: '-чу',
//		  40: '-чы',
//		  50: '-чү',
//		  60: '-чы',
//		  70: '-чи',
//		  80: '-чи',
//		  90: '-чу',
//		  100: '-чү'
//		};
//		return e.defineLocale('ky', {
//		  months: 'январь_февраль_март_апрель_май_июнь_июль_август_сентябрь_октябрь_ноябрь_декабрь'.split('_'),
//		  monthsShort: 'янв_фев_март_апр_май_июнь_июль_авг_сен_окт_ноя_дек'.split('_'),
//		  weekdays: 'Жекшемби_Дүйшөмбү_Шейшемби_Шаршемби_Бейшемби_Жума_Ишемби'.split('_'),
//		  weekdaysShort: 'Жек_Дүй_Шей_Шар_Бей_Жум_Ише'.split('_'),
//		  weekdaysMin: 'Жк_Дй_Шй_Шр_Бй_Жм_Иш'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'dddd, D MMMM YYYY HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Бүгүн саат] LT',
//			nextDay: '[Эртең саат] LT',
//			nextWeek: 'dddd [саат] LT',
//			lastDay: '[Кече саат] LT',
//			lastWeek: '[Өткен аптанын] dddd [күнү] [саат] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s ичинде',
//			past: '%s мурун',
//			s: 'бирнече секунд',
//			ss: '%d секунд',
//			m: 'бир мүнөт',
//			mm: '%d мүнөт',
//			h: 'бир саат',
//			hh: '%d саат',
//			d: 'бир күн',
//			dd: '%d күн',
//			M: 'бир ай',
//			MM: '%d ай',
//			y: 'бир жыл',
//			yy: '%d жыл'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(чи|чы|чү|чу)/,
//		  ordinal: function (e) {
//			var n = e % 10,
//			r = e >= 100 ? 100 : null;
//			return e + (t[e] || t[n] || t[r])
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = {
//			m: [
//			  'eng Minutt',
//			  'enger Minutt'
//			],
//			h: [
//			  'eng Stonn',
//			  'enger Stonn'
//			],
//			d: [
//			  'een Dag',
//			  'engem Dag'
//			],
//			M: [
//			  'ee Mount',
//			  'engem Mount'
//			],
//			y: [
//			  'ee Joer',
//			  'engem Joer'
//			]
//		  };
//		  return t ? a[n][0] : a[n][1]
//		}
//		function n(e) {
//		  return a(e.substr(0, e.indexOf(' '))) ? 'a ' + e : 'an ' + e
//		}
//		function r(e) {
//		  return a(e.substr(0, e.indexOf(' '))) ? 'viru ' + e : 'virun ' + e
//		}
//		function a(e) {
//		  if (e = parseInt(e, 10), isNaN(e)) return !1;
//		  if (e < 0) return !0;
//		  if (e < 10) return 4 <= e && e <= 7;
//		  if (e < 100) {
//			var t = e % 10,
//			n = e / 10;
//			return a(0 === t ? n : t)
//		  }
//		  if (e < 10000) {
//			for (; e >= 10; ) e /= 10;
//			return a(e)
//		  }
//		  return e /= 1000,
//		  a(e)
//		}
//		return e.defineLocale('lb', {
//		  months: 'Januar_Februar_Mäerz_Abrëll_Mee_Juni_Juli_August_September_Oktober_November_Dezember'.split('_'),
//		  monthsShort: 'Jan._Febr._Mrz._Abr._Mee_Jun._Jul._Aug._Sept._Okt._Nov._Dez.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'Sonndeg_Méindeg_Dënschdeg_Mëttwoch_Donneschdeg_Freideg_Samschdeg'.split('_'),
//		  weekdaysShort: 'So._Mé._Dë._Më._Do._Fr._Sa.'.split('_'),
//		  weekdaysMin: 'So_Mé_Dë_Më_Do_Fr_Sa'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm [Auer]',
//			LTS: 'H:mm:ss [Auer]',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm [Auer]',
//			LLLL: 'dddd, D. MMMM YYYY H:mm [Auer]'
//		  },
//		  calendar: {
//			sameDay: '[Haut um] LT',
//			sameElse: 'L',
//			nextDay: '[Muer um] LT',
//			nextWeek: 'dddd [um] LT',
//			lastDay: '[Gëschter um] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 2:
//				case 4:
//				  return '[Leschten] dddd [um] LT';
//				default:
//				  return '[Leschte] dddd [um] LT'
//			  }
//			}
//		  },
//		  relativeTime: {
//			future: n,
//			past: r,
//			s: 'e puer Sekonnen',
//			ss: '%d Sekonnen',
//			m: t,
//			mm: '%d Minutten',
//			h: t,
//			hh: '%d Stonnen',
//			d: t,
//			dd: '%d Deeg',
//			M: t,
//			MM: '%d Méint',
//			y: t,
//			yy: '%d Joer'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('lo', {
//		  months: 'ມັງກອນ_ກຸມພາ_ມີນາ_ເມສາ_ພຶດສະພາ_ມິຖຸນາ_ກໍລະກົດ_ສິງຫາ_ກັນຍາ_ຕຸລາ_ພະຈິກ_ທັນວາ'.split('_'),
//		  monthsShort: 'ມັງກອນ_ກຸມພາ_ມີນາ_ເມສາ_ພຶດສະພາ_ມິຖຸນາ_ກໍລະກົດ_ສິງຫາ_ກັນຍາ_ຕຸລາ_ພະຈິກ_ທັນວາ'.split('_'),
//		  weekdays: 'ອາທິດ_ຈັນ_ອັງຄານ_ພຸດ_ພະຫັດ_ສຸກ_ເສົາ'.split('_'),
//		  weekdaysShort: 'ທິດ_ຈັນ_ອັງຄານ_ພຸດ_ພະຫັດ_ສຸກ_ເສົາ'.split('_'),
//		  weekdaysMin: 'ທ_ຈ_ອຄ_ພ_ພຫ_ສກ_ສ'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY HH:mm',
//			LLLL: 'ວັນdddd D MMMM YYYY HH:mm'
//		  },
//		  meridiemParse: /ຕອນເຊົ້າ|ຕອນແລງ/,
//		  isPM: function (e) {
//			return 'ຕອນແລງ' === e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 12 ? 'ຕອນເຊົ້າ' : 'ຕອນແລງ'
//		  },
//		  calendar: {
//			sameDay: '[ມື້ນີ້ເວລາ] LT',
//			nextDay: '[ມື້ອື່ນເວລາ] LT',
//			nextWeek: '[ວັນ]dddd[ໜ້າເວລາ] LT',
//			lastDay: '[ມື້ວານນີ້ເວລາ] LT',
//			lastWeek: '[ວັນ]dddd[ແລ້ວນີ້ເວລາ] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'ອີກ %s',
//			past: '%sຜ່ານມາ',
//			s: 'ບໍ່ເທົ່າໃດວິນາທີ',
//			ss: '%d ວິນາທີ',
//			m: '1 ນາທີ',
//			mm: '%d ນາທີ',
//			h: '1 ຊົ່ວໂມງ',
//			hh: '%d ຊົ່ວໂມງ',
//			d: '1 ມື້',
//			dd: '%d ມື້',
//			M: '1 ເດືອນ',
//			MM: '%d ເດືອນ',
//			y: '1 ປີ',
//			yy: '%d ປີ'
//		  },
//		  dayOfMonthOrdinalParse: /(ທີ່)\d{1,2}/,
//		  ordinal: function (e) {
//			return 'ທີ່' + e
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  return t ? 'kelios sekundės' : r ? 'kelių sekundžių' : 'kelias sekundes'
//		}
//		function n(e, t, n, r) {
//		  return t ? a(n) [0] : r ? a(n) [1] : a(n) [2]
//		}
//		function r(e) {
//		  return e % 10 == 0 || e > 10 && e < 20
//		}
//		function a(e) {
//		  return i[e].split('_')
//		}
//		function o(e, t, o, i) {
//		  var s = e + ' ';
//		  return 1 === e ? s + n(e, t, o[0], i)  : t ? s + (r(e) ? a(o) [1] : a(o) [0])  : i ? s + a(o) [1] : s + (r(e) ? a(o) [1] : a(o) [2])
//		}
//		var i = {
//		  ss: 'sekundė_sekundžių_sekundes',
//		  m: 'minutė_minutės_minutę',
//		  mm: 'minutės_minučių_minutes',
//		  h: 'valanda_valandos_valandą',
//		  hh: 'valandos_valandų_valandas',
//		  d: 'diena_dienos_dieną',
//		  dd: 'dienos_dienų_dienas',
//		  M: 'mėnuo_mėnesio_mėnesį',
//		  MM: 'mėnesiai_mėnesių_mėnesius',
//		  y: 'metai_metų_metus',
//		  yy: 'metai_metų_metus'
//		};
//		return e.defineLocale('lt', {
//		  months: {
//			format: 'sausio_vasario_kovo_balandžio_gegužės_birželio_liepos_rugpjūčio_rugsėjo_spalio_lapkričio_gruodžio'.split('_'),
//			standalone: 'sausis_vasaris_kovas_balandis_gegužė_birželis_liepa_rugpjūtis_rugsėjis_spalis_lapkritis_gruodis'.split('_'),
//			isFormat: /D[oD]?(\[[^\[\]]*\]|\s)+MMMM?|MMMM?(\[[^\[\]]*\]|\s)+D[oD]?/
//		  },
//		  monthsShort: 'sau_vas_kov_bal_geg_bir_lie_rgp_rgs_spa_lap_grd'.split('_'),
//		  weekdays: {
//			format: 'sekmadienį_pirmadienį_antradienį_trečiadienį_ketvirtadienį_penktadienį_šeštadienį'.split('_'),
//			standalone: 'sekmadienis_pirmadienis_antradienis_trečiadienis_ketvirtadienis_penktadienis_šeštadienis'.split('_'),
//			isFormat: /dddd HH:mm/
//		  },
//		  weekdaysShort: 'Sek_Pir_Ant_Tre_Ket_Pen_Šeš'.split('_'),
//		  weekdaysMin: 'S_P_A_T_K_Pn_Š'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'YYYY-MM-DD',
//			LL: 'YYYY [m.] MMMM D [d.]',
//			LLL: 'YYYY [m.] MMMM D [d.], HH:mm [val.]',
//			LLLL: 'YYYY [m.] MMMM D [d.], dddd, HH:mm [val.]',
//			l: 'YYYY-MM-DD',
//			ll: 'YYYY [m.] MMMM D [d.]',
//			lll: 'YYYY [m.] MMMM D [d.], HH:mm [val.]',
//			llll: 'YYYY [m.] MMMM D [d.], ddd, HH:mm [val.]'
//		  },
//		  calendar: {
//			sameDay: '[Šiandien] LT',
//			nextDay: '[Rytoj] LT',
//			nextWeek: 'dddd LT',
//			lastDay: '[Vakar] LT',
//			lastWeek: '[Praėjusį] dddd LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'po %s',
//			past: 'prieš %s',
//			s: t,
//			ss: o,
//			m: n,
//			mm: o,
//			h: n,
//			hh: o,
//			d: n,
//			dd: o,
//			M: n,
//			MM: o,
//			y: n,
//			yy: o
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-oji/,
//		  ordinal: function (e) {
//			return e + '-oji'
//		  },
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n) {
//		  return n ? t % 10 == 1 && t % 100 != 11 ? e[2] : e[3] : t % 10 == 1 && t % 100 != 11 ? e[0] : e[1]
//		}
//		function n(e, n, r) {
//		  return e + ' ' + t(o[r], e, n)
//		}
//		function r(e, n, r) {
//		  return t(o[r], e, n)
//		}
//		function a(e, t) {
//		  return t ? 'dažas sekundes' : 'dažām sekundēm'
//		}
//		var o = {
//		  ss: 'sekundes_sekundēm_sekunde_sekundes'.split('_'),
//		  m: 'minūtes_minūtēm_minūte_minūtes'.split('_'),
//		  mm: 'minūtes_minūtēm_minūte_minūtes'.split('_'),
//		  h: 'stundas_stundām_stunda_stundas'.split('_'),
//		  hh: 'stundas_stundām_stunda_stundas'.split('_'),
//		  d: 'dienas_dienām_diena_dienas'.split('_'),
//		  dd: 'dienas_dienām_diena_dienas'.split('_'),
//		  M: 'mēneša_mēnešiem_mēnesis_mēneši'.split('_'),
//		  MM: 'mēneša_mēnešiem_mēnesis_mēneši'.split('_'),
//		  y: 'gada_gadiem_gads_gadi'.split('_'),
//		  yy: 'gada_gadiem_gads_gadi'.split('_')
//		};
//		return e.defineLocale('lv', {
//		  months: 'janvāris_februāris_marts_aprīlis_maijs_jūnijs_jūlijs_augusts_septembris_oktobris_novembris_decembris'.split('_'),
//		  monthsShort: 'jan_feb_mar_apr_mai_jūn_jūl_aug_sep_okt_nov_dec'.split('_'),
//		  weekdays: 'svētdiena_pirmdiena_otrdiena_trešdiena_ceturtdiena_piektdiena_sestdiena'.split('_'),
//		  weekdaysShort: 'Sv_P_O_T_C_Pk_S'.split('_'),
//		  weekdaysMin: 'Sv_P_O_T_C_Pk_S'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD.MM.YYYY.',
//			LL: 'YYYY. [gada] D. MMMM',
//			LLL: 'YYYY. [gada] D. MMMM, HH:mm',
//			LLLL: 'YYYY. [gada] D. MMMM, dddd, HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[Šodien pulksten] LT',
//			nextDay: '[Rīt pulksten] LT',
//			nextWeek: 'dddd [pulksten] LT',
//			lastDay: '[Vakar pulksten] LT',
//			lastWeek: '[Pagājušā] dddd [pulksten] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'pēc %s',
//			past: 'pirms %s',
//			s: a,
//			ss: n,
//			m: r,
//			mm: n,
//			h: r,
//			hh: n,
//			d: r,
//			dd: n,
//			M: r,
//			MM: n,
//			y: r,
//			yy: n
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		var t = {
//		  words: {
//			ss: [
//			  'sekund',
//			  'sekunda',
//			  'sekundi'
//			],
//			m: [
//			  'jedan minut',
//			  'jednog minuta'
//			],
//			mm: [
//			  'minut',
//			  'minuta',
//			  'minuta'
//			],
//			h: [
//			  'jedan sat',
//			  'jednog sata'
//			],
//			hh: [
//			  'sat',
//			  'sata',
//			  'sati'
//			],
//			dd: [
//			  'dan',
//			  'dana',
//			  'dana'
//			],
//			MM: [
//			  'mjesec',
//			  'mjeseca',
//			  'mjeseci'
//			],
//			yy: [
//			  'godina',
//			  'godine',
//			  'godina'
//			]
//		  },
//		  correctGrammaticalCase: function (e, t) {
//			return 1 === e ? t[0] : e >= 2 && e <= 4 ? t[1] : t[2]
//		  },
//		  translate: function (e, n, r) {
//			var a = t.words[r];
//			return 1 === r.length ? n ? a[0] : a[1] : e + ' ' + t.correctGrammaticalCase(e, a)
//		  }
//		};
//		return e.defineLocale('me', {
//		  months: 'januar_februar_mart_april_maj_jun_jul_avgust_septembar_oktobar_novembar_decembar'.split('_'),
//		  monthsShort: 'jan._feb._mar._apr._maj_jun_jul_avg._sep._okt._nov._dec.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'nedjelja_ponedjeljak_utorak_srijeda_četvrtak_petak_subota'.split('_'),
//		  weekdaysShort: 'ned._pon._uto._sri._čet._pet._sub.'.split('_'),
//		  weekdaysMin: 'ne_po_ut_sr_če_pe_su'.split('_'),
//		  weekdaysParseExact: !0,
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'DD.MM.YYYY',
//			LL: 'D. MMMM YYYY',
//			LLL: 'D. MMMM YYYY H:mm',
//			LLLL: 'dddd, D. MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[danas u] LT',
//			nextDay: '[sjutra u] LT',
//			nextWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				  return '[u] [nedjelju] [u] LT';
//				case 3:
//				  return '[u] [srijedu] [u] LT';
//				case 6:
//				  return '[u] [subotu] [u] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[u] dddd [u] LT'
//			  }
//			},
//			lastDay: '[juče u] LT',
//			lastWeek: function () {
//			  return ['[prošle] [nedjelje] [u] LT',
//			  '[prošlog] [ponedjeljka] [u] LT',
//			  '[prošlog] [utorka] [u] LT',
//			  '[prošle] [srijede] [u] LT',
//			  '[prošlog] [četvrtka] [u] LT',
//			  '[prošlog] [petka] [u] LT',
//			  '[prošle] [subote] [u] LT'][this.day()]
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'za %s',
//			past: 'prije %s',
//			s: 'nekoliko sekundi',
//			ss: t.translate,
//			m: t.translate,
//			mm: t.translate,
//			h: t.translate,
//			hh: t.translate,
//			d: 'dan',
//			dd: t.translate,
//			M: 'mjesec',
//			MM: t.translate,
//			y: 'godinu',
//			yy: t.translate
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}\./,
//		  ordinal: '%d.',
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('mi', {
//		  months: 'Kohi-tāte_Hui-tanguru_Poutū-te-rangi_Paenga-whāwhā_Haratua_Pipiri_Hōngoingoi_Here-turi-kōkā_Mahuru_Whiringa-ā-nuku_Whiringa-ā-rangi_Hakihea'.split('_'),
//		  monthsShort: 'Kohi_Hui_Pou_Pae_Hara_Pipi_Hōngoi_Here_Mahu_Whi-nu_Whi-ra_Haki'.split('_'),
//		  monthsRegex: /(?:['a-z\u0101\u014D\u016B]+\-?){1,3}/i,
//		  monthsStrictRegex: /(?:['a-z\u0101\u014D\u016B]+\-?){1,3}/i,
//		  monthsShortRegex: /(?:['a-z\u0101\u014D\u016B]+\-?){1,3}/i,
//		  monthsShortStrictRegex: /(?:['a-z\u0101\u014D\u016B]+\-?){1,2}/i,
//		  weekdays: 'Rātapu_Mane_Tūrei_Wenerei_Tāite_Paraire_Hātarei'.split('_'),
//		  weekdaysShort: 'Ta_Ma_Tū_We_Tāi_Pa_Hā'.split('_'),
//		  weekdaysMin: 'Ta_Ma_Tū_We_Tāi_Pa_Hā'.split('_'),
//		  longDateFormat: {
//			LT: 'HH:mm',
//			LTS: 'HH:mm:ss',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY [i] HH:mm',
//			LLLL: 'dddd, D MMMM YYYY [i] HH:mm'
//		  },
//		  calendar: {
//			sameDay: '[i teie mahana, i] LT',
//			nextDay: '[apopo i] LT',
//			nextWeek: 'dddd [i] LT',
//			lastDay: '[inanahi i] LT',
//			lastWeek: 'dddd [whakamutunga i] LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'i roto i %s',
//			past: '%s i mua',
//			s: 'te hēkona ruarua',
//			ss: '%d hēkona',
//			m: 'he meneti',
//			mm: '%d meneti',
//			h: 'te haora',
//			hh: '%d haora',
//			d: 'he ra',
//			dd: '%d ra',
//			M: 'he marama',
//			MM: '%d marama',
//			y: 'he tau',
//			yy: '%d tau'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}º/,
//		  ordinal: '%dº',
//		  week: {
//			dow: 1,
//			doy: 4
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('mk', {
//		  months: 'јануари_февруари_март_април_мај_јуни_јули_август_септември_октомври_ноември_декември'.split('_'),
//		  monthsShort: 'јан_фев_мар_апр_мај_јун_јул_авг_сеп_окт_ное_дек'.split('_'),
//		  weekdays: 'недела_понеделник_вторник_среда_четврток_петок_сабота'.split('_'),
//		  weekdaysShort: 'нед_пон_вто_сре_чет_пет_саб'.split('_'),
//		  weekdaysMin: 'нe_пo_вт_ср_че_пе_сa'.split('_'),
//		  longDateFormat: {
//			LT: 'H:mm',
//			LTS: 'H:mm:ss',
//			L: 'D.MM.YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY H:mm',
//			LLLL: 'dddd, D MMMM YYYY H:mm'
//		  },
//		  calendar: {
//			sameDay: '[Денес во] LT',
//			nextDay: '[Утре во] LT',
//			nextWeek: '[Во] dddd [во] LT',
//			lastDay: '[Вчера во] LT',
//			lastWeek: function () {
//			  switch (this.day()) {
//				case 0:
//				case 3:
//				case 6:
//				  return '[Изминатата] dddd [во] LT';
//				case 1:
//				case 2:
//				case 4:
//				case 5:
//				  return '[Изминатиот] dddd [во] LT'
//			  }
//			},
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: 'после %s',
//			past: 'пред %s',
//			s: 'неколку секунди',
//			ss: '%d секунди',
//			m: 'минута',
//			mm: '%d минути',
//			h: 'час',
//			hh: '%d часа',
//			d: 'ден',
//			dd: '%d дена',
//			M: 'месец',
//			MM: '%d месеци',
//			y: 'година',
//			yy: '%d години'
//		  },
//		  dayOfMonthOrdinalParse: /\d{1,2}-(ев|ен|ти|ви|ри|ми)/,
//		  ordinal: function (e) {
//			var t = e % 10,
//			n = e % 100;
//			return 0 === e ? e + '-ев' : 0 === n ? e + '-ен' : n > 10 && n < 20 ? e + '-ти' : 1 === t ? e + '-ви' : 2 === t ? e + '-ри' : 7 === t || 8 === t ? e + '-ми' : e + '-ти'
//		  },
//		  week: {
//			dow: 1,
//			doy: 7
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		return e.defineLocale('ml', {
//		  months: 'ജനുവരി_ഫെബ്രുവരി_മാർച്ച്_ഏപ്രിൽ_മേയ്_ജൂൺ_ജൂലൈ_ഓഗസ്റ്റ്_സെപ്റ്റംബർ_ഒക്ടോബർ_നവംബർ_ഡിസംബർ'.split('_'),
//		  monthsShort: 'ജനു._ഫെബ്രു._മാർ._ഏപ്രി._മേയ്_ജൂൺ_ജൂലൈ._ഓഗ._സെപ്റ്റ._ഒക്ടോ._നവം._ഡിസം.'.split('_'),
//		  monthsParseExact: !0,
//		  weekdays: 'ഞായറാഴ്ച_തിങ്കളാഴ്ച_ചൊവ്വാഴ്ച_ബുധനാഴ്ച_വ്യാഴാഴ്ച_വെള്ളിയാഴ്ച_ശനിയാഴ്ച'.split('_'),
//		  weekdaysShort: 'ഞായർ_തിങ്കൾ_ചൊവ്വ_ബുധൻ_വ്യാഴം_വെള്ളി_ശനി'.split('_'),
//		  weekdaysMin: 'ഞാ_തി_ചൊ_ബു_വ്യാ_വെ_ശ'.split('_'),
//		  longDateFormat: {
//			LT: 'A h:mm -നു',
//			LTS: 'A h:mm:ss -നു',
//			L: 'DD/MM/YYYY',
//			LL: 'D MMMM YYYY',
//			LLL: 'D MMMM YYYY, A h:mm -നു',
//			LLLL: 'dddd, D MMMM YYYY, A h:mm -നു'
//		  },
//		  calendar: {
//			sameDay: '[ഇന്ന്] LT',
//			nextDay: '[നാളെ] LT',
//			nextWeek: 'dddd, LT',
//			lastDay: '[ഇന്നലെ] LT',
//			lastWeek: '[കഴിഞ്ഞ] dddd, LT',
//			sameElse: 'L'
//		  },
//		  relativeTime: {
//			future: '%s കഴിഞ്ഞ്',
//			past: '%s മുൻപ്',
//			s: 'അൽപ നിമിഷങ്ങൾ',
//			ss: '%d സെക്കൻഡ്',
//			m: 'ഒരു മിനിറ്റ്',
//			mm: '%d മിനിറ്റ്',
//			h: 'ഒരു മണിക്കൂർ',
//			hh: '%d മണിക്കൂർ',
//			d: 'ഒരു ദിവസം',
//			dd: '%d ദിവസം',
//			M: 'ഒരു മാസം',
//			MM: '%d മാസം',
//			y: 'ഒരു വർഷം',
//			yy: '%d വർഷം'
//		  },
//		  meridiemParse: /രാത്രി|രാവിലെ|ഉച്ച കഴിഞ്ഞ്|വൈകുന്നേരം|രാത്രി/i,
//		  meridiemHour: function (e, t) {
//			return 12 === e && (e = 0),
//			'രാത്രി' === t && e >= 4 || 'ഉച്ച കഴിഞ്ഞ്' === t || 'വൈകുന്നേരം' === t ? e + 12 : e
//		  },
//		  meridiem: function (e, t, n) {
//			return e < 4 ? 'രാത്രി' : e < 12 ? 'രാവിലെ' : e < 17 ? 'ഉച്ച കഴിഞ്ഞ്' : e < 20 ? 'വൈകുന്നേരം' : 'രാത്രി'
//		  }
//		})
//	  })
//	},
//	function (e, t, n) {
//	  !function (e, t) {
//		t(n(3))
//	  }(0, function (e) {
//		'use strict';
//		function t(e, t, n, r) {
//		  var a = '';
//		  if (t) switch (n) {
//			case 's':
//			  a = 'काही सेकंद';
//			  break;
//			case 'ss':
//			  a = '%d सेकंद';
//			  break;
//			case 'm':
//			  a = 'एक मिनिट';
//			  break;
//			case 'mm':
//			  a = '%d मिनिटे';
//			  break;
//			case 'h':
//			  a = 'एक तास';
//			  break;
//			case 'hh':
//			  a = '%d तास';
//			  break;
//			case 'd':
//			  a = 'एक दिवस';
//			  break;
//			case 'dd':
//			  a = '%d दिवस';
//			  break;
//			case 'M':
//			  a = 'एक महिना';
//			  break;
//			case 'MM':
//			  a = '%d महिने';
//			  break;
//			case 'y':
//			  a = 'एक वर्ष';
//			  break;
//			case 'yy':
//			  a = '%d वर्षे'
//		  } else switch (n) {
//			case 's':
//			  a = 'काही सेकंदां';
//			  break;
//			case 'ss':
//			  a = '%d सेकंदां';
//			  break;
//			case 'm':
//			  a = 'एका मिनिटा';
//			  break;
//			case 'mm':
//			  a = '%d मिनिटां';
//			  break;
//			case 'h':
//			  a = 'एका तासा';
//			  break;
//			case 'hh':
//			  a = '%d तासां';
//			  break;
//			case 'd':
//			  a = 'एका दिवसा';
//			  break;
//			case 'dd':
//			  a = '%d दिवसां';
//			  break;
//			case 'M':
//			  a = 'एका महिन्या';
//			  break;
//			case 'MM':
//			  a = '%d महिन्यां';
//			  break;
//			case 'y':
//			  a = 'एका वर्षा';
//			  break;
//			case 'yy':
//			  a = '%d वर्षां'
//		  }
//		  return a.replace(/%d/i, e)
//	  }
//	  var n = {
//		1: '१',
//		2: '२',
//		3: '३',
//		4: '४',
//		5: '५',
//		6: '६',
//		7: '७',
//		8: '८',
//		9: '९',
//		0: '०'
//	},
//	r = {
//	  '१': '1',
//	  '२': '2',
//	  '३': '3',
//	  '४': '4',
//	  '५': '5',
//	  '६': '6',
//	  '७': '7',
//	  '८': '8',
//	  '९': '9',
//	  '०': '0'
//  };
//  return e.defineLocale('mr', {
//	months: 'जानेवारी_फेब्रुवारी_मार्च_एप्रिल_मे_जून_जुलै_ऑगस्ट_सप्टेंबर_ऑक्टोबर_नोव्हेंबर_डिसेंबर'.split('_'),
//	monthsShort: 'जाने._फेब्रु._मार्च._एप्रि._मे._जून._जुलै._ऑग._सप्टें._ऑक्टो._नोव्हें._डिसें.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'रविवार_सोमवार_मंगळवार_बुधवार_गुरूवार_शुक्रवार_शनिवार'.split('_'),
//	weekdaysShort: 'रवि_सोम_मंगळ_बुध_गुरू_शुक्र_शनि'.split('_'),
//	weekdaysMin: 'र_सो_मं_बु_गु_शु_श'.split('_'),
//	longDateFormat: {
//	  LT: 'A h:mm वाजता',
//	  LTS: 'A h:mm:ss वाजता',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY, A h:mm वाजता',
//	  LLLL: 'dddd, D MMMM YYYY, A h:mm वाजता'
//	},
//	calendar: {
//	  sameDay: '[आज] LT',
//	  nextDay: '[उद्या] LT',
//	  nextWeek: 'dddd, LT',
//	  lastDay: '[काल] LT',
//	  lastWeek: '[मागील] dddd, LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%sमध्ये',
//	  past: '%sपूर्वी',
//	  s: t,
//	  ss: t,
//	  m: t,
//	  mm: t,
//	  h: t,
//	  hh: t,
//	  d: t,
//	  dd: t,
//	  M: t,
//	  MM: t,
//	  y: t,
//	  yy: t
//	},
//	preparse: function (e) {
//	  return e.replace(/[१२३४५६७८९०]/g, function (e) {
//		return r[e]
//	  })
//	},
//	postformat: function (e) {
//	  return e.replace(/\d/g, function (e) {
//		return n[e]
//	  })
//	},
//	meridiemParse: /रात्री|सकाळी|दुपारी|सायंकाळी/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'रात्री' === t ? e < 4 ? e : e + 12 : 'सकाळी' === t ? e : 'दुपारी' === t ? e >= 10 ? e : e + 12 : 'सायंकाळी' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 4 ? 'रात्री' : e < 10 ? 'सकाळी' : e < 17 ? 'दुपारी' : e < 20 ? 'सायंकाळी' : 'रात्री'
//	},
//	week: {
//	  dow: 0,
//	  doy: 6
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('ms', {
//	months: 'Januari_Februari_Mac_April_Mei_Jun_Julai_Ogos_September_Oktober_November_Disember'.split('_'),
//	monthsShort: 'Jan_Feb_Mac_Apr_Mei_Jun_Jul_Ogs_Sep_Okt_Nov_Dis'.split('_'),
//	weekdays: 'Ahad_Isnin_Selasa_Rabu_Khamis_Jumaat_Sabtu'.split('_'),
//	weekdaysShort: 'Ahd_Isn_Sel_Rab_Kha_Jum_Sab'.split('_'),
//	weekdaysMin: 'Ah_Is_Sl_Rb_Km_Jm_Sb'.split('_'),
//	longDateFormat: {
//	  LT: 'HH.mm',
//	  LTS: 'HH.mm.ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY [pukul] HH.mm',
//	  LLLL: 'dddd, D MMMM YYYY [pukul] HH.mm'
//	},
//	meridiemParse: /pagi|tengahari|petang|malam/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'pagi' === t ? e : 'tengahari' === t ? e >= 11 ? e : e + 12 : 'petang' === t || 'malam' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 11 ? 'pagi' : e < 15 ? 'tengahari' : e < 19 ? 'petang' : 'malam'
//	},
//	calendar: {
//	  sameDay: '[Hari ini pukul] LT',
//	  nextDay: '[Esok pukul] LT',
//	  nextWeek: 'dddd [pukul] LT',
//	  lastDay: '[Kelmarin pukul] LT',
//	  lastWeek: 'dddd [lepas pukul] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'dalam %s',
//	  past: '%s yang lepas',
//	  s: 'beberapa saat',
//	  ss: '%d saat',
//	  m: 'seminit',
//	  mm: '%d minit',
//	  h: 'sejam',
//	  hh: '%d jam',
//	  d: 'sehari',
//	  dd: '%d hari',
//	  M: 'sebulan',
//	  MM: '%d bulan',
//	  y: 'setahun',
//	  yy: '%d tahun'
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('ms-my', {
//	months: 'Januari_Februari_Mac_April_Mei_Jun_Julai_Ogos_September_Oktober_November_Disember'.split('_'),
//	monthsShort: 'Jan_Feb_Mac_Apr_Mei_Jun_Jul_Ogs_Sep_Okt_Nov_Dis'.split('_'),
//	weekdays: 'Ahad_Isnin_Selasa_Rabu_Khamis_Jumaat_Sabtu'.split('_'),
//	weekdaysShort: 'Ahd_Isn_Sel_Rab_Kha_Jum_Sab'.split('_'),
//	weekdaysMin: 'Ah_Is_Sl_Rb_Km_Jm_Sb'.split('_'),
//	longDateFormat: {
//	  LT: 'HH.mm',
//	  LTS: 'HH.mm.ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY [pukul] HH.mm',
//	  LLLL: 'dddd, D MMMM YYYY [pukul] HH.mm'
//	},
//	meridiemParse: /pagi|tengahari|petang|malam/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'pagi' === t ? e : 'tengahari' === t ? e >= 11 ? e : e + 12 : 'petang' === t || 'malam' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 11 ? 'pagi' : e < 15 ? 'tengahari' : e < 19 ? 'petang' : 'malam'
//	},
//	calendar: {
//	  sameDay: '[Hari ini pukul] LT',
//	  nextDay: '[Esok pukul] LT',
//	  nextWeek: 'dddd [pukul] LT',
//	  lastDay: '[Kelmarin pukul] LT',
//	  lastWeek: 'dddd [lepas pukul] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'dalam %s',
//	  past: '%s yang lepas',
//	  s: 'beberapa saat',
//	  ss: '%d saat',
//	  m: 'seminit',
//	  mm: '%d minit',
//	  h: 'sejam',
//	  hh: '%d jam',
//	  d: 'sehari',
//	  dd: '%d hari',
//	  M: 'sebulan',
//	  MM: '%d bulan',
//	  y: 'setahun',
//	  yy: '%d tahun'
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('mt', {
//	months: 'Jannar_Frar_Marzu_April_Mejju_Ġunju_Lulju_Awwissu_Settembru_Ottubru_Novembru_Diċembru'.split('_'),
//	monthsShort: 'Jan_Fra_Mar_Apr_Mej_Ġun_Lul_Aww_Set_Ott_Nov_Diċ'.split('_'),
//	weekdays: 'Il-Ħadd_It-Tnejn_It-Tlieta_L-Erbgħa_Il-Ħamis_Il-Ġimgħa_Is-Sibt'.split('_'),
//	weekdaysShort: 'Ħad_Tne_Tli_Erb_Ħam_Ġim_Sib'.split('_'),
//	weekdaysMin: 'Ħa_Tn_Tl_Er_Ħa_Ġi_Si'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Illum fil-]LT',
//	  nextDay: '[Għada fil-]LT',
//	  nextWeek: 'dddd [fil-]LT',
//	  lastDay: '[Il-bieraħ fil-]LT',
//	  lastWeek: 'dddd [li għadda] [fil-]LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'f’ %s',
//	  past: '%s ilu',
//	  s: 'ftit sekondi',
//	  ss: '%d sekondi',
//	  m: 'minuta',
//	  mm: '%d minuti',
//	  h: 'siegħa',
//	  hh: '%d siegħat',
//	  d: 'ġurnata',
//	  dd: '%d ġranet',
//	  M: 'xahar',
//	  MM: '%d xhur',
//	  y: 'sena',
//	  yy: '%d sni'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}º/,
//	ordinal: '%dº',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	1: '၁',
//	2: '၂',
//	3: '၃',
//	4: '၄',
//	5: '၅',
//	6: '၆',
//	7: '၇',
//	8: '၈',
//	9: '၉',
//	0: '၀'
//  },
//  n = {
//	'၁': '1',
//	'၂': '2',
//	'၃': '3',
//	'၄': '4',
//	'၅': '5',
//	'၆': '6',
//	'၇': '7',
//	'၈': '8',
//	'၉': '9',
//	'၀': '0'
//  };
//  return e.defineLocale('my', {
//	months: 'ဇန်နဝါရီ_ဖေဖော်ဝါရီ_မတ်_ဧပြီ_မေ_ဇွန်_ဇူလိုင်_သြဂုတ်_စက်တင်ဘာ_အောက်တိုဘာ_နိုဝင်ဘာ_ဒီဇင်ဘာ'.split('_'),
//	monthsShort: 'ဇန်_ဖေ_မတ်_ပြီ_မေ_ဇွန်_လိုင်_သြ_စက်_အောက်_နို_ဒီ'.split('_'),
//	weekdays: 'တနင်္ဂနွေ_တနင်္လာ_အင်္ဂါ_ဗုဒ္ဓဟူး_ကြာသပတေး_သောကြာ_စနေ'.split('_'),
//	weekdaysShort: 'နွေ_လာ_ဂါ_ဟူး_ကြာ_သော_နေ'.split('_'),
//	weekdaysMin: 'နွေ_လာ_ဂါ_ဟူး_ကြာ_သော_နေ'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[ယနေ.] LT [မှာ]',
//	  nextDay: '[မနက်ဖြန်] LT [မှာ]',
//	  nextWeek: 'dddd LT [မှာ]',
//	  lastDay: '[မနေ.က] LT [မှာ]',
//	  lastWeek: '[ပြီးခဲ့သော] dddd LT [မှာ]',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'လာမည့် %s မှာ',
//	  past: 'လွန်ခဲ့သော %s က',
//	  s: 'စက္ကန်.အနည်းငယ်',
//	  ss: '%d စက္ကန့်',
//	  m: 'တစ်မိနစ်',
//	  mm: '%d မိနစ်',
//	  h: 'တစ်နာရီ',
//	  hh: '%d နာရီ',
//	  d: 'တစ်ရက်',
//	  dd: '%d ရက်',
//	  M: 'တစ်လ',
//	  MM: '%d လ',
//	  y: 'တစ်နှစ်',
//	  yy: '%d နှစ်'
//	},
//	preparse: function (e) {
//	  return e.replace(/[၁၂၃၄၅၆၇၈၉၀]/g, function (e) {
//		return n[e]
//	  })
//	},
//	postformat: function (e) {
//	  return e.replace(/\d/g, function (e) {
//		return t[e]
//	  })
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('nb', {
//	months: 'januar_februar_mars_april_mai_juni_juli_august_september_oktober_november_desember'.split('_'),
//	monthsShort: 'jan._feb._mars_april_mai_juni_juli_aug._sep._okt._nov._des.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'søndag_mandag_tirsdag_onsdag_torsdag_fredag_lørdag'.split('_'),
//	weekdaysShort: 'sø._ma._ti._on._to._fr._lø.'.split('_'),
//	weekdaysMin: 'sø_ma_ti_on_to_fr_lø'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY [kl.] HH:mm',
//	  LLLL: 'dddd D. MMMM YYYY [kl.] HH:mm'
//	},
//	calendar: {
//	  sameDay: '[i dag kl.] LT',
//	  nextDay: '[i morgen kl.] LT',
//	  nextWeek: 'dddd [kl.] LT',
//	  lastDay: '[i går kl.] LT',
//	  lastWeek: '[forrige] dddd [kl.] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'om %s',
//	  past: '%s siden',
//	  s: 'noen sekunder',
//	  ss: '%d sekunder',
//	  m: 'ett minutt',
//	  mm: '%d minutter',
//	  h: 'en time',
//	  hh: '%d timer',
//	  d: 'en dag',
//	  dd: '%d dager',
//	  M: 'en måned',
//	  MM: '%d måneder',
//	  y: 'ett år',
//	  yy: '%d år'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	1: '१',
//	2: '२',
//	3: '३',
//	4: '४',
//	5: '५',
//	6: '६',
//	7: '७',
//	8: '८',
//	9: '९',
//	0: '०'
//  },
//  n = {
//	'१': '1',
//	'२': '2',
//	'३': '3',
//	'४': '4',
//	'५': '5',
//	'६': '6',
//	'७': '7',
//	'८': '8',
//	'९': '9',
//	'०': '0'
//  };
//  return e.defineLocale('ne', {
//	months: 'जनवरी_फेब्रुवरी_मार्च_अप्रिल_मई_जुन_जुलाई_अगष्ट_सेप्टेम्बर_अक्टोबर_नोभेम्बर_डिसेम्बर'.split('_'),
//	monthsShort: 'जन._फेब्रु._मार्च_अप्रि._मई_जुन_जुलाई._अग._सेप्ट._अक्टो._नोभे._डिसे.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'आइतबार_सोमबार_मङ्गलबार_बुधबार_बिहिबार_शुक्रबार_शनिबार'.split('_'),
//	weekdaysShort: 'आइत._सोम._मङ्गल._बुध._बिहि._शुक्र._शनि.'.split('_'),
//	weekdaysMin: 'आ._सो._मं._बु._बि._शु._श.'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'Aको h:mm बजे',
//	  LTS: 'Aको h:mm:ss बजे',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY, Aको h:mm बजे',
//	  LLLL: 'dddd, D MMMM YYYY, Aको h:mm बजे'
//	},
//	preparse: function (e) {
//	  return e.replace(/[१२३४५६७८९०]/g, function (e) {
//		return n[e]
//	  })
//	},
//	postformat: function (e) {
//	  return e.replace(/\d/g, function (e) {
//		return t[e]
//	  })
//	},
//	meridiemParse: /राति|बिहान|दिउँसो|साँझ/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'राति' === t ? e < 4 ? e : e + 12 : 'बिहान' === t ? e : 'दिउँसो' === t ? e >= 10 ? e : e + 12 : 'साँझ' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 3 ? 'राति' : e < 12 ? 'बिहान' : e < 16 ? 'दिउँसो' : e < 20 ? 'साँझ' : 'राति'
//	},
//	calendar: {
//	  sameDay: '[आज] LT',
//	  nextDay: '[भोलि] LT',
//	  nextWeek: '[आउँदो] dddd[,] LT',
//	  lastDay: '[हिजो] LT',
//	  lastWeek: '[गएको] dddd[,] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%sमा',
//	  past: '%s अगाडि',
//	  s: 'केही क्षण',
//	  ss: '%d सेकेण्ड',
//	  m: 'एक मिनेट',
//	  mm: '%d मिनेट',
//	  h: 'एक घण्टा',
//	  hh: '%d घण्टा',
//	  d: 'एक दिन',
//	  dd: '%d दिन',
//	  M: 'एक महिना',
//	  MM: '%d महिना',
//	  y: 'एक बर्ष',
//	  yy: '%d बर्ष'
//	},
//	week: {
//	  dow: 0,
//	  doy: 6
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = 'jan._feb._mrt._apr._mei_jun._jul._aug._sep._okt._nov._dec.'.split('_'),
//  n = 'jan_feb_mrt_apr_mei_jun_jul_aug_sep_okt_nov_dec'.split('_'),
//  r = [
//	/^jan/i,
//	/^feb/i,
//	/^maart|mrt.?$/i,
//	/^apr/i,
//	/^mei$/i,
//	/^jun[i.]?$/i,
//	/^jul[i.]?$/i,
//	/^aug/i,
//	/^sep/i,
//	/^okt/i,
//	/^nov/i,
//	/^dec/i
//  ],
//  a = /^(januari|februari|maart|april|mei|april|ju[nl]i|augustus|september|oktober|november|december|jan\.?|feb\.?|mrt\.?|apr\.?|ju[nl]\.?|aug\.?|sep\.?|okt\.?|nov\.?|dec\.?)/i;
//  return e.defineLocale('nl', {
//	months: 'januari_februari_maart_april_mei_juni_juli_augustus_september_oktober_november_december'.split('_'),
//	monthsShort: function (e, r) {
//	  return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//	},
//	monthsRegex: a,
//	monthsShortRegex: a,
//	monthsStrictRegex: /^(januari|februari|maart|mei|ju[nl]i|april|augustus|september|oktober|november|december)/i,
//	monthsShortStrictRegex: /^(jan\.?|feb\.?|mrt\.?|apr\.?|mei|ju[nl]\.?|aug\.?|sep\.?|okt\.?|nov\.?|dec\.?)/i,
//	monthsParse: r,
//	longMonthsParse: r,
//	shortMonthsParse: r,
//	weekdays: 'zondag_maandag_dinsdag_woensdag_donderdag_vrijdag_zaterdag'.split('_'),
//	weekdaysShort: 'zo._ma._di._wo._do._vr._za.'.split('_'),
//	weekdaysMin: 'zo_ma_di_wo_do_vr_za'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD-MM-YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[vandaag om] LT',
//	  nextDay: '[morgen om] LT',
//	  nextWeek: 'dddd [om] LT',
//	  lastDay: '[gisteren om] LT',
//	  lastWeek: '[afgelopen] dddd [om] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'over %s',
//	  past: '%s geleden',
//	  s: 'een paar seconden',
//	  ss: '%d seconden',
//	  m: 'één minuut',
//	  mm: '%d minuten',
//	  h: 'één uur',
//	  hh: '%d uur',
//	  d: 'één dag',
//	  dd: '%d dagen',
//	  M: 'één maand',
//	  MM: '%d maanden',
//	  y: 'één jaar',
//	  yy: '%d jaar'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(ste|de)/,
//	ordinal: function (e) {
//	  return e + (1 === e || 8 === e || e >= 20 ? 'ste' : 'de')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = 'jan._feb._mrt._apr._mei_jun._jul._aug._sep._okt._nov._dec.'.split('_'),
//  n = 'jan_feb_mrt_apr_mei_jun_jul_aug_sep_okt_nov_dec'.split('_'),
//  r = [
//	/^jan/i,
//	/^feb/i,
//	/^maart|mrt.?$/i,
//	/^apr/i,
//	/^mei$/i,
//	/^jun[i.]?$/i,
//	/^jul[i.]?$/i,
//	/^aug/i,
//	/^sep/i,
//	/^okt/i,
//	/^nov/i,
//	/^dec/i
//  ],
//  a = /^(januari|februari|maart|april|mei|april|ju[nl]i|augustus|september|oktober|november|december|jan\.?|feb\.?|mrt\.?|apr\.?|ju[nl]\.?|aug\.?|sep\.?|okt\.?|nov\.?|dec\.?)/i;
//  return e.defineLocale('nl-be', {
//	months: 'januari_februari_maart_april_mei_juni_juli_augustus_september_oktober_november_december'.split('_'),
//	monthsShort: function (e, r) {
//	  return e ? /-MMM-/.test(r) ? n[e.month()] : t[e.month()] : t
//	},
//	monthsRegex: a,
//	monthsShortRegex: a,
//	monthsStrictRegex: /^(januari|februari|maart|mei|ju[nl]i|april|augustus|september|oktober|november|december)/i,
//	monthsShortStrictRegex: /^(jan\.?|feb\.?|mrt\.?|apr\.?|mei|ju[nl]\.?|aug\.?|sep\.?|okt\.?|nov\.?|dec\.?)/i,
//	monthsParse: r,
//	longMonthsParse: r,
//	shortMonthsParse: r,
//	weekdays: 'zondag_maandag_dinsdag_woensdag_donderdag_vrijdag_zaterdag'.split('_'),
//	weekdaysShort: 'zo._ma._di._wo._do._vr._za.'.split('_'),
//	weekdaysMin: 'zo_ma_di_wo_do_vr_za'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[vandaag om] LT',
//	  nextDay: '[morgen om] LT',
//	  nextWeek: 'dddd [om] LT',
//	  lastDay: '[gisteren om] LT',
//	  lastWeek: '[afgelopen] dddd [om] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'over %s',
//	  past: '%s geleden',
//	  s: 'een paar seconden',
//	  ss: '%d seconden',
//	  m: 'één minuut',
//	  mm: '%d minuten',
//	  h: 'één uur',
//	  hh: '%d uur',
//	  d: 'één dag',
//	  dd: '%d dagen',
//	  M: 'één maand',
//	  MM: '%d maanden',
//	  y: 'één jaar',
//	  yy: '%d jaar'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(ste|de)/,
//	ordinal: function (e) {
//	  return e + (1 === e || 8 === e || e >= 20 ? 'ste' : 'de')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('nn', {
//	months: 'januar_februar_mars_april_mai_juni_juli_august_september_oktober_november_desember'.split('_'),
//	monthsShort: 'jan_feb_mar_apr_mai_jun_jul_aug_sep_okt_nov_des'.split('_'),
//	weekdays: 'sundag_måndag_tysdag_onsdag_torsdag_fredag_laurdag'.split('_'),
//	weekdaysShort: 'sun_mån_tys_ons_tor_fre_lau'.split('_'),
//	weekdaysMin: 'su_må_ty_on_to_fr_lø'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY [kl.] H:mm',
//	  LLLL: 'dddd D. MMMM YYYY [kl.] HH:mm'
//	},
//	calendar: {
//	  sameDay: '[I dag klokka] LT',
//	  nextDay: '[I morgon klokka] LT',
//	  nextWeek: 'dddd [klokka] LT',
//	  lastDay: '[I går klokka] LT',
//	  lastWeek: '[Føregåande] dddd [klokka] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'om %s',
//	  past: '%s sidan',
//	  s: 'nokre sekund',
//	  ss: '%d sekund',
//	  m: 'eit minutt',
//	  mm: '%d minutt',
//	  h: 'ein time',
//	  hh: '%d timar',
//	  d: 'ein dag',
//	  dd: '%d dagar',
//	  M: 'ein månad',
//	  MM: '%d månader',
//	  y: 'eit år',
//	  yy: '%d år'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	1: '੧',
//	2: '੨',
//	3: '੩',
//	4: '੪',
//	5: '੫',
//	6: '੬',
//	7: '੭',
//	8: '੮',
//	9: '੯',
//	0: '੦'
//  },
//  n = {
//	'੧': '1',
//	'੨': '2',
//	'੩': '3',
//	'੪': '4',
//	'੫': '5',
//	'੬': '6',
//	'੭': '7',
//	'੮': '8',
//	'੯': '9',
//	'੦': '0'
//  };
//  return e.defineLocale('pa-in', {
//	months: 'ਜਨਵਰੀ_ਫ਼ਰਵਰੀ_ਮਾਰਚ_ਅਪ੍ਰੈਲ_ਮਈ_ਜੂਨ_ਜੁਲਾਈ_ਅਗਸਤ_ਸਤੰਬਰ_ਅਕਤੂਬਰ_ਨਵੰਬਰ_ਦਸੰਬਰ'.split('_'),
//	monthsShort: 'ਜਨਵਰੀ_ਫ਼ਰਵਰੀ_ਮਾਰਚ_ਅਪ੍ਰੈਲ_ਮਈ_ਜੂਨ_ਜੁਲਾਈ_ਅਗਸਤ_ਸਤੰਬਰ_ਅਕਤੂਬਰ_ਨਵੰਬਰ_ਦਸੰਬਰ'.split('_'),
//	weekdays: 'ਐਤਵਾਰ_ਸੋਮਵਾਰ_ਮੰਗਲਵਾਰ_ਬੁਧਵਾਰ_ਵੀਰਵਾਰ_ਸ਼ੁੱਕਰਵਾਰ_ਸ਼ਨੀਚਰਵਾਰ'.split('_'),
//	weekdaysShort: 'ਐਤ_ਸੋਮ_ਮੰਗਲ_ਬੁਧ_ਵੀਰ_ਸ਼ੁਕਰ_ਸ਼ਨੀ'.split('_'),
//	weekdaysMin: 'ਐਤ_ਸੋਮ_ਮੰਗਲ_ਬੁਧ_ਵੀਰ_ਸ਼ੁਕਰ_ਸ਼ਨੀ'.split('_'),
//	longDateFormat: {
//	  LT: 'A h:mm ਵਜੇ',
//	  LTS: 'A h:mm:ss ਵਜੇ',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY, A h:mm ਵਜੇ',
//	  LLLL: 'dddd, D MMMM YYYY, A h:mm ਵਜੇ'
//	},
//	calendar: {
//	  sameDay: '[ਅਜ] LT',
//	  nextDay: '[ਕਲ] LT',
//	  nextWeek: 'dddd, LT',
//	  lastDay: '[ਕਲ] LT',
//	  lastWeek: '[ਪਿਛਲੇ] dddd, LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s ਵਿੱਚ',
//	  past: '%s ਪਿਛਲੇ',
//	  s: 'ਕੁਝ ਸਕਿੰਟ',
//	  ss: '%d ਸਕਿੰਟ',
//	  m: 'ਇਕ ਮਿੰਟ',
//	  mm: '%d ਮਿੰਟ',
//	  h: 'ਇੱਕ ਘੰਟਾ',
//	  hh: '%d ਘੰਟੇ',
//	  d: 'ਇੱਕ ਦਿਨ',
//	  dd: '%d ਦਿਨ',
//	  M: 'ਇੱਕ ਮਹੀਨਾ',
//	  MM: '%d ਮਹੀਨੇ',
//	  y: 'ਇੱਕ ਸਾਲ',
//	  yy: '%d ਸਾਲ'
//	},
//	preparse: function (e) {
//	  return e.replace(/[੧੨੩੪੫੬੭੮੯੦]/g, function (e) {
//		return n[e]
//	  })
//	},
//	postformat: function (e) {
//	  return e.replace(/\d/g, function (e) {
//		return t[e]
//	  })
//	},
//	meridiemParse: /ਰਾਤ|ਸਵੇਰ|ਦੁਪਹਿਰ|ਸ਼ਾਮ/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'ਰਾਤ' === t ? e < 4 ? e : e + 12 : 'ਸਵੇਰ' === t ? e : 'ਦੁਪਹਿਰ' === t ? e >= 10 ? e : e + 12 : 'ਸ਼ਾਮ' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 4 ? 'ਰਾਤ' : e < 10 ? 'ਸਵੇਰ' : e < 17 ? 'ਦੁਪਹਿਰ' : e < 20 ? 'ਸ਼ਾਮ' : 'ਰਾਤ'
//	},
//	week: {
//	  dow: 0,
//	  doy: 6
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e) {
//	return e % 10 < 5 && e % 10 > 1 && ~~(e / 10) % 10 != 1
//  }
//  function n(e, n, r) {
//	var a = e + ' ';
//	switch (r) {
//	  case 'ss':
//		return a + (t(e) ? 'sekundy' : 'sekund');
//	  case 'm':
//		return n ? 'minuta' : 'minutę';
//	  case 'mm':
//		return a + (t(e) ? 'minuty' : 'minut');
//	  case 'h':
//		return n ? 'godzina' : 'godzinę';
//	  case 'hh':
//		return a + (t(e) ? 'godziny' : 'godzin');
//	  case 'MM':
//		return a + (t(e) ? 'miesiące' : 'miesięcy');
//	  case 'yy':
//		return a + (t(e) ? 'lata' : 'lat')
//	}
//  }
//  var r = 'styczeń_luty_marzec_kwiecień_maj_czerwiec_lipiec_sierpień_wrzesień_październik_listopad_grudzień'.split('_'),
//  a = 'stycznia_lutego_marca_kwietnia_maja_czerwca_lipca_sierpnia_września_października_listopada_grudnia'.split('_');
//  return e.defineLocale('pl', {
//	months: function (e, t) {
//	  return e ? '' === t ? '(' + a[e.month()] + '|' + r[e.month()] + ')' : /D MMMM/.test(t) ? a[e.month()] : r[e.month()] : r
//	},
//	monthsShort: 'sty_lut_mar_kwi_maj_cze_lip_sie_wrz_paź_lis_gru'.split('_'),
//	weekdays: 'niedziela_poniedziałek_wtorek_środa_czwartek_piątek_sobota'.split('_'),
//	weekdaysShort: 'ndz_pon_wt_śr_czw_pt_sob'.split('_'),
//	weekdaysMin: 'Nd_Pn_Wt_Śr_Cz_Pt_So'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Dziś o] LT',
//	  nextDay: '[Jutro o] LT',
//	  nextWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[W niedzielę o] LT';
//		  case 2:
//			return '[We wtorek o] LT';
//		  case 3:
//			return '[W środę o] LT';
//		  case 6:
//			return '[W sobotę o] LT';
//		  default:
//			return '[W] dddd [o] LT'
//		}
//	  },
//	  lastDay: '[Wczoraj o] LT',
//	  lastWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[W zeszłą niedzielę o] LT';
//		  case 3:
//			return '[W zeszłą środę o] LT';
//		  case 6:
//			return '[W zeszłą sobotę o] LT';
//		  default:
//			return '[W zeszły] dddd [o] LT'
//		}
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'za %s',
//	  past: '%s temu',
//	  s: 'kilka sekund',
//	  ss: n,
//	  m: n,
//	  mm: n,
//	  h: n,
//	  hh: n,
//	  d: '1 dzień',
//	  dd: '%d dni',
//	  M: 'miesiąc',
//	  MM: n,
//	  y: 'rok',
//	  yy: n
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('pt', {
//	months: 'janeiro_fevereiro_março_abril_maio_junho_julho_agosto_setembro_outubro_novembro_dezembro'.split('_'),
//	monthsShort: 'jan_fev_mar_abr_mai_jun_jul_ago_set_out_nov_dez'.split('_'),
//	weekdays: 'Domingo_Segunda-feira_Terça-feira_Quarta-feira_Quinta-feira_Sexta-feira_Sábado'.split('_'),
//	weekdaysShort: 'Dom_Seg_Ter_Qua_Qui_Sex_Sáb'.split('_'),
//	weekdaysMin: 'Do_2ª_3ª_4ª_5ª_6ª_Sá'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D [de] MMMM [de] YYYY',
//	  LLL: 'D [de] MMMM [de] YYYY HH:mm',
//	  LLLL: 'dddd, D [de] MMMM [de] YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Hoje às] LT',
//	  nextDay: '[Amanhã às] LT',
//	  nextWeek: 'dddd [às] LT',
//	  lastDay: '[Ontem às] LT',
//	  lastWeek: function () {
//		return 0 === this.day() || 6 === this.day() ? '[Último] dddd [às] LT' : '[Última] dddd [às] LT'
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'em %s',
//	  past: 'há %s',
//	  s: 'segundos',
//	  ss: '%d segundos',
//	  m: 'um minuto',
//	  mm: '%d minutos',
//	  h: 'uma hora',
//	  hh: '%d horas',
//	  d: 'um dia',
//	  dd: '%d dias',
//	  M: 'um mês',
//	  MM: '%d meses',
//	  y: 'um ano',
//	  yy: '%d anos'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}º/,
//	ordinal: '%dº',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('pt-br', {
//	months: 'janeiro_fevereiro_março_abril_maio_junho_julho_agosto_setembro_outubro_novembro_dezembro'.split('_'),
//	monthsShort: 'jan_fev_mar_abr_mai_jun_jul_ago_set_out_nov_dez'.split('_'),
//	weekdays: 'Domingo_Segunda-feira_Terça-feira_Quarta-feira_Quinta-feira_Sexta-feira_Sábado'.split('_'),
//	weekdaysShort: 'Dom_Seg_Ter_Qua_Qui_Sex_Sáb'.split('_'),
//	weekdaysMin: 'Do_2ª_3ª_4ª_5ª_6ª_Sá'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D [de] MMMM [de] YYYY',
//	  LLL: 'D [de] MMMM [de] YYYY [às] HH:mm',
//	  LLLL: 'dddd, D [de] MMMM [de] YYYY [às] HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Hoje às] LT',
//	  nextDay: '[Amanhã às] LT',
//	  nextWeek: 'dddd [às] LT',
//	  lastDay: '[Ontem às] LT',
//	  lastWeek: function () {
//		return 0 === this.day() || 6 === this.day() ? '[Último] dddd [às] LT' : '[Última] dddd [às] LT'
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'em %s',
//	  past: '%s atrás',
//	  s: 'poucos segundos',
//	  ss: '%d segundos',
//	  m: 'um minuto',
//	  mm: '%d minutos',
//	  h: 'uma hora',
//	  hh: '%d horas',
//	  d: 'um dia',
//	  dd: '%d dias',
//	  M: 'um mês',
//	  MM: '%d meses',
//	  y: 'um ano',
//	  yy: '%d anos'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}º/,
//	ordinal: '%dº'
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e, t, n) {
//	var r = {
//	  ss: 'secunde',
//	  mm: 'minute',
//	  hh: 'ore',
//	  dd: 'zile',
//	  MM: 'luni',
//	  yy: 'ani'
//	},
//	a = ' ';
//	return (e % 100 >= 20 || e >= 100 && e % 100 == 0) && (a = ' de '),
//	e + a + r[n]
//  }
//  return e.defineLocale('ro', {
//	months: 'ianuarie_februarie_martie_aprilie_mai_iunie_iulie_august_septembrie_octombrie_noiembrie_decembrie'.split('_'),
//	monthsShort: 'ian._febr._mart._apr._mai_iun._iul._aug._sept._oct._nov._dec.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'duminică_luni_marți_miercuri_joi_vineri_sâmbătă'.split('_'),
//	weekdaysShort: 'Dum_Lun_Mar_Mie_Joi_Vin_Sâm'.split('_'),
//	weekdaysMin: 'Du_Lu_Ma_Mi_Jo_Vi_Sâ'.split('_'),
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY H:mm',
//	  LLLL: 'dddd, D MMMM YYYY H:mm'
//	},
//	calendar: {
//	  sameDay: '[azi la] LT',
//	  nextDay: '[mâine la] LT',
//	  nextWeek: 'dddd [la] LT',
//	  lastDay: '[ieri la] LT',
//	  lastWeek: '[fosta] dddd [la] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'peste %s',
//	  past: '%s în urmă',
//	  s: 'câteva secunde',
//	  ss: t,
//	  m: 'un minut',
//	  mm: t,
//	  h: 'o oră',
//	  hh: t,
//	  d: 'o zi',
//	  dd: t,
//	  M: 'o lună',
//	  MM: t,
//	  y: 'un an',
//	  yy: t
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e, t) {
//	var n = e.split('_');
//	return t % 10 == 1 && t % 100 != 11 ? n[0] : t % 10 >= 2 && t % 10 <= 4 && (t % 100 < 10 || t % 100 >= 20) ? n[1] : n[2]
//  }
//  function n(e, n, r) {
//	var a = {
//	  ss: n ? 'секунда_секунды_секунд' : 'секунду_секунды_секунд',
//	  mm: n ? 'минута_минуты_минут' : 'минуту_минуты_минут',
//	  hh: 'час_часа_часов',
//	  dd: 'день_дня_дней',
//	  MM: 'месяц_месяца_месяцев',
//	  yy: 'год_года_лет'
//	};
//	return 'm' === r ? n ? 'минута' : 'минуту' : e + ' ' + t(a[r], + e)
//  }
//  var r = [
//	/^янв/i,
//	/^фев/i,
//	/^мар/i,
//	/^апр/i,
//	/^ма[йя]/i,
//	/^июн/i,
//	/^июл/i,
//	/^авг/i,
//	/^сен/i,
//	/^окт/i,
//	/^ноя/i,
//	/^дек/i
//  ];
//  return e.defineLocale('ru', {
//	months: {
//	  format: 'января_февраля_марта_апреля_мая_июня_июля_августа_сентября_октября_ноября_декабря'.split('_'),
//	  standalone: 'январь_февраль_март_апрель_май_июнь_июль_август_сентябрь_октябрь_ноябрь_декабрь'.split('_')
//	},
//	monthsShort: {
//	  format: 'янв._февр._мар._апр._мая_июня_июля_авг._сент._окт._нояб._дек.'.split('_'),
//	  standalone: 'янв._февр._март_апр._май_июнь_июль_авг._сент._окт._нояб._дек.'.split('_')
//	},
//	weekdays: {
//	  standalone: 'воскресенье_понедельник_вторник_среда_четверг_пятница_суббота'.split('_'),
//	  format: 'воскресенье_понедельник_вторник_среду_четверг_пятницу_субботу'.split('_'),
//	  isFormat: /\[ ?[Вв] ?(?:прошлую|следующую|эту)? ?\] ?dddd/
//	},
//	weekdaysShort: 'вс_пн_вт_ср_чт_пт_сб'.split('_'),
//	weekdaysMin: 'вс_пн_вт_ср_чт_пт_сб'.split('_'),
//	monthsParse: r,
//	longMonthsParse: r,
//	shortMonthsParse: r,
//	monthsRegex: /^(январ[ья]|янв\.?|феврал[ья]|февр?\.?|марта?|мар\.?|апрел[ья]|апр\.?|ма[йя]|июн[ья]|июн\.?|июл[ья]|июл\.?|августа?|авг\.?|сентябр[ья]|сент?\.?|октябр[ья]|окт\.?|ноябр[ья]|нояб?\.?|декабр[ья]|дек\.?)/i,
//	monthsShortRegex: /^(январ[ья]|янв\.?|феврал[ья]|февр?\.?|марта?|мар\.?|апрел[ья]|апр\.?|ма[йя]|июн[ья]|июн\.?|июл[ья]|июл\.?|августа?|авг\.?|сентябр[ья]|сент?\.?|октябр[ья]|окт\.?|ноябр[ья]|нояб?\.?|декабр[ья]|дек\.?)/i,
//	monthsStrictRegex: /^(январ[яь]|феврал[яь]|марта?|апрел[яь]|ма[яй]|июн[яь]|июл[яь]|августа?|сентябр[яь]|октябр[яь]|ноябр[яь]|декабр[яь])/i,
//	monthsShortStrictRegex: /^(янв\.|февр?\.|мар[т.]|апр\.|ма[яй]|июн[ья.]|июл[ья.]|авг\.|сент?\.|окт\.|нояб?\.|дек\.)/i,
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY г.',
//	  LLL: 'D MMMM YYYY г., H:mm',
//	  LLLL: 'dddd, D MMMM YYYY г., H:mm'
//	},
//	calendar: {
//	  sameDay: '[Сегодня в] LT',
//	  nextDay: '[Завтра в] LT',
//	  lastDay: '[Вчера в] LT',
//	  nextWeek: function (e) {
//		if (e.week() === this.week()) return 2 === this.day() ? '[Во] dddd [в] LT' : '[В] dddd [в] LT';
//		switch (this.day()) {
//		  case 0:
//			return '[В следующее] dddd [в] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//			return '[В следующий] dddd [в] LT';
//		  case 3:
//		  case 5:
//		  case 6:
//			return '[В следующую] dddd [в] LT'
//		}
//	  },
//	  lastWeek: function (e) {
//		if (e.week() === this.week()) return 2 === this.day() ? '[Во] dddd [в] LT' : '[В] dddd [в] LT';
//		switch (this.day()) {
//		  case 0:
//			return '[В прошлое] dddd [в] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//			return '[В прошлый] dddd [в] LT';
//		  case 3:
//		  case 5:
//		  case 6:
//			return '[В прошлую] dddd [в] LT'
//		}
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'через %s',
//	  past: '%s назад',
//	  s: 'несколько секунд',
//	  ss: n,
//	  m: n,
//	  mm: n,
//	  h: 'час',
//	  hh: n,
//	  d: 'день',
//	  dd: n,
//	  M: 'месяц',
//	  MM: n,
//	  y: 'год',
//	  yy: n
//	},
//	meridiemParse: /ночи|утра|дня|вечера/i,
//	isPM: function (e) {
//	  return /^(дня|вечера)$/.test(e)
//	},
//	meridiem: function (e, t, n) {
//	  return e < 4 ? 'ночи' : e < 12 ? 'утра' : e < 17 ? 'дня' : 'вечера'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}-(й|го|я)/,
//	ordinal: function (e, t) {
//	  switch (t) {
//		case 'M':
//		case 'd':
//		case 'DDD':
//		  return e + '-й';
//		case 'D':
//		  return e + '-го';
//		case 'w':
//		case 'W':
//		  return e + '-я';
//		default:
//		  return e
//	  }
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = [
//	'جنوري',
//	'فيبروري',
//	'مارچ',
//	'اپريل',
//	'مئي',
//	'جون',
//	'جولاءِ',
//	'آگسٽ',
//	'سيپٽمبر',
//	'آڪٽوبر',
//	'نومبر',
//	'ڊسمبر'
//  ],
//  n = [
//	'آچر',
//	'سومر',
//	'اڱارو',
//	'اربع',
//	'خميس',
//	'جمع',
//	'ڇنڇر'
//  ];
//  return e.defineLocale('sd', {
//	months: t,
//	monthsShort: t,
//	weekdays: n,
//	weekdaysShort: n,
//	weekdaysMin: n,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd، D MMMM YYYY HH:mm'
//	},
//	meridiemParse: /صبح|شام/,
//	isPM: function (e) {
//	  return 'شام' === e
//	},
//	meridiem: function (e, t, n) {
//	  return e < 12 ? 'صبح' : 'شام'
//	},
//	calendar: {
//	  sameDay: '[اڄ] LT',
//	  nextDay: '[سڀاڻي] LT',
//	  nextWeek: 'dddd [اڳين هفتي تي] LT',
//	  lastDay: '[ڪالهه] LT',
//	  lastWeek: '[گزريل هفتي] dddd [تي] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s پوء',
//	  past: '%s اڳ',
//	  s: 'چند سيڪنڊ',
//	  ss: '%d سيڪنڊ',
//	  m: 'هڪ منٽ',
//	  mm: '%d منٽ',
//	  h: 'هڪ ڪلاڪ',
//	  hh: '%d ڪلاڪ',
//	  d: 'هڪ ڏينهن',
//	  dd: '%d ڏينهن',
//	  M: 'هڪ مهينو',
//	  MM: '%d مهينا',
//	  y: 'هڪ سال',
//	  yy: '%d سال'
//	},
//	preparse: function (e) {
//	  return e.replace(/،/g, ',')
//	},
//	postformat: function (e) {
//	  return e.replace(/,/g, '،')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('se', {
//	months: 'ođđajagemánnu_guovvamánnu_njukčamánnu_cuoŋománnu_miessemánnu_geassemánnu_suoidnemánnu_borgemánnu_čakčamánnu_golggotmánnu_skábmamánnu_juovlamánnu'.split('_'),
//	monthsShort: 'ođđj_guov_njuk_cuo_mies_geas_suoi_borg_čakč_golg_skáb_juov'.split('_'),
//	weekdays: 'sotnabeaivi_vuossárga_maŋŋebárga_gaskavahkku_duorastat_bearjadat_lávvardat'.split('_'),
//	weekdaysShort: 'sotn_vuos_maŋ_gask_duor_bear_láv'.split('_'),
//	weekdaysMin: 's_v_m_g_d_b_L'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'MMMM D. [b.] YYYY',
//	  LLL: 'MMMM D. [b.] YYYY [ti.] HH:mm',
//	  LLLL: 'dddd, MMMM D. [b.] YYYY [ti.] HH:mm'
//	},
//	calendar: {
//	  sameDay: '[otne ti] LT',
//	  nextDay: '[ihttin ti] LT',
//	  nextWeek: 'dddd [ti] LT',
//	  lastDay: '[ikte ti] LT',
//	  lastWeek: '[ovddit] dddd [ti] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s geažes',
//	  past: 'maŋit %s',
//	  s: 'moadde sekunddat',
//	  ss: '%d sekunddat',
//	  m: 'okta minuhta',
//	  mm: '%d minuhtat',
//	  h: 'okta diimmu',
//	  hh: '%d diimmut',
//	  d: 'okta beaivi',
//	  dd: '%d beaivvit',
//	  M: 'okta mánnu',
//	  MM: '%d mánut',
//	  y: 'okta jahki',
//	  yy: '%d jagit'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('si', {
//	months: 'ජනවාරි_පෙබරවාරි_මාර්තු_අප්‍රේල්_මැයි_ජූනි_ජූලි_අගෝස්තු_සැප්තැම්බර්_ඔක්තෝබර්_නොවැම්බර්_දෙසැම්බර්'.split('_'),
//	monthsShort: 'ජන_පෙබ_මාර්_අප්_මැයි_ජූනි_ජූලි_අගෝ_සැප්_ඔක්_නොවැ_දෙසැ'.split('_'),
//	weekdays: 'ඉරිදා_සඳුදා_අඟහරුවාදා_බදාදා_බ්‍රහස්පතින්දා_සිකුරාදා_සෙනසුරාදා'.split('_'),
//	weekdaysShort: 'ඉරි_සඳු_අඟ_බදා_බ්‍රහ_සිකු_සෙන'.split('_'),
//	weekdaysMin: 'ඉ_ස_අ_බ_බ්‍ර_සි_සෙ'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'a h:mm',
//	  LTS: 'a h:mm:ss',
//	  L: 'YYYY/MM/DD',
//	  LL: 'YYYY MMMM D',
//	  LLL: 'YYYY MMMM D, a h:mm',
//	  LLLL: 'YYYY MMMM D [වැනි] dddd, a h:mm:ss'
//	},
//	calendar: {
//	  sameDay: '[අද] LT[ට]',
//	  nextDay: '[හෙට] LT[ට]',
//	  nextWeek: 'dddd LT[ට]',
//	  lastDay: '[ඊයේ] LT[ට]',
//	  lastWeek: '[පසුගිය] dddd LT[ට]',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%sකින්',
//	  past: '%sකට පෙර',
//	  s: 'තත්පර කිහිපය',
//	  ss: 'තත්පර %d',
//	  m: 'මිනිත්තුව',
//	  mm: 'මිනිත්තු %d',
//	  h: 'පැය',
//	  hh: 'පැය %d',
//	  d: 'දිනය',
//	  dd: 'දින %d',
//	  M: 'මාසය',
//	  MM: 'මාස %d',
//	  y: 'වසර',
//	  yy: 'වසර %d'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2} වැනි/,
//	ordinal: function (e) {
//	  return e + ' වැනි'
//	},
//	meridiemParse: /පෙර වරු|පස් වරු|පෙ.ව|ප.ව./,
//	isPM: function (e) {
//	  return 'ප.ව.' === e || 'පස් වරු' === e
//	},
//	meridiem: function (e, t, n) {
//	  return e > 11 ? n ? 'ප.ව.' : 'පස් වරු' : n ? 'පෙ.ව.' : 'පෙර වරු'
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e) {
//	return e > 1 && e < 5
//  }
//  function n(e, n, r, a) {
//	var o = e + ' ';
//	switch (r) {
//	  case 's':
//		return n || a ? 'pár sekúnd' : 'pár sekundami';
//	  case 'ss':
//		return n || a ? o + (t(e) ? 'sekundy' : 'sekúnd')  : o + 'sekundami';
//	  case 'm':
//		return n ? 'minúta' : a ? 'minútu' : 'minútou';
//	  case 'mm':
//		return n || a ? o + (t(e) ? 'minúty' : 'minút')  : o + 'minútami';
//	  case 'h':
//		return n ? 'hodina' : a ? 'hodinu' : 'hodinou';
//	  case 'hh':
//		return n || a ? o + (t(e) ? 'hodiny' : 'hodín')  : o + 'hodinami';
//	  case 'd':
//		return n || a ? 'deň' : 'dňom';
//	  case 'dd':
//		return n || a ? o + (t(e) ? 'dni' : 'dní')  : o + 'dňami';
//	  case 'M':
//		return n || a ? 'mesiac' : 'mesiacom';
//	  case 'MM':
//		return n || a ? o + (t(e) ? 'mesiace' : 'mesiacov')  : o + 'mesiacmi';
//	  case 'y':
//		return n || a ? 'rok' : 'rokom';
//	  case 'yy':
//		return n || a ? o + (t(e) ? 'roky' : 'rokov')  : o + 'rokmi'
//	}
//  }
//  var r = 'január_február_marec_apríl_máj_jún_júl_august_september_október_november_december'.split('_'),
//  a = 'jan_feb_mar_apr_máj_jún_júl_aug_sep_okt_nov_dec'.split('_');
//  return e.defineLocale('sk', {
//	months: r,
//	monthsShort: a,
//	weekdays: 'nedeľa_pondelok_utorok_streda_štvrtok_piatok_sobota'.split('_'),
//	weekdaysShort: 'ne_po_ut_st_št_pi_so'.split('_'),
//	weekdaysMin: 'ne_po_ut_st_št_pi_so'.split('_'),
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY H:mm',
//	  LLLL: 'dddd D. MMMM YYYY H:mm'
//	},
//	calendar: {
//	  sameDay: '[dnes o] LT',
//	  nextDay: '[zajtra o] LT',
//	  nextWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[v nedeľu o] LT';
//		  case 1:
//		  case 2:
//			return '[v] dddd [o] LT';
//		  case 3:
//			return '[v stredu o] LT';
//		  case 4:
//			return '[vo štvrtok o] LT';
//		  case 5:
//			return '[v piatok o] LT';
//		  case 6:
//			return '[v sobotu o] LT'
//		}
//	  },
//	  lastDay: '[včera o] LT',
//	  lastWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[minulú nedeľu o] LT';
//		  case 1:
//		  case 2:
//			return '[minulý] dddd [o] LT';
//		  case 3:
//			return '[minulú stredu o] LT';
//		  case 4:
//		  case 5:
//			return '[minulý] dddd [o] LT';
//		  case 6:
//			return '[minulú sobotu o] LT'
//		}
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'za %s',
//	  past: 'pred %s',
//	  s: n,
//	  ss: n,
//	  m: n,
//	  mm: n,
//	  h: n,
//	  hh: n,
//	  d: n,
//	  dd: n,
//	  M: n,
//	  MM: n,
//	  y: n,
//	  yy: n
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e, t, n, r) {
//	var a = e + ' ';
//	switch (n) {
//	  case 's':
//		return t || r ? 'nekaj sekund' : 'nekaj sekundami';
//	  case 'ss':
//		return a += 1 === e ? t ? 'sekundo' : 'sekundi' : 2 === e ? t || r ? 'sekundi' : 'sekundah' : e < 5 ? t || r ? 'sekunde' : 'sekundah' : 'sekund';
//	  case 'm':
//		return t ? 'ena minuta' : 'eno minuto';
//	  case 'mm':
//		return a += 1 === e ? t ? 'minuta' : 'minuto' : 2 === e ? t || r ? 'minuti' : 'minutama' : e < 5 ? t || r ? 'minute' : 'minutami' : t || r ? 'minut' : 'minutami';
//	  case 'h':
//		return t ? 'ena ura' : 'eno uro';
//	  case 'hh':
//		return a += 1 === e ? t ? 'ura' : 'uro' : 2 === e ? t || r ? 'uri' : 'urama' : e < 5 ? t || r ? 'ure' : 'urami' : t || r ? 'ur' : 'urami';
//	  case 'd':
//		return t || r ? 'en dan' : 'enim dnem';
//	  case 'dd':
//		return a += 1 === e ? t || r ? 'dan' : 'dnem' : 2 === e ? t || r ? 'dni' : 'dnevoma' : t || r ? 'dni' : 'dnevi';
//	  case 'M':
//		return t || r ? 'en mesec' : 'enim mesecem';
//	  case 'MM':
//		return a += 1 === e ? t || r ? 'mesec' : 'mesecem' : 2 === e ? t || r ? 'meseca' : 'mesecema' : e < 5 ? t || r ? 'mesece' : 'meseci' : t || r ? 'mesecev' : 'meseci';
//	  case 'y':
//		return t || r ? 'eno leto' : 'enim letom';
//	  case 'yy':
//		return a += 1 === e ? t || r ? 'leto' : 'letom' : 2 === e ? t || r ? 'leti' : 'letoma' : e < 5 ? t || r ? 'leta' : 'leti' : t || r ? 'let'  : 'leti'
//	}
//  }
//  return e.defineLocale('sl', {
//	months: 'januar_februar_marec_april_maj_junij_julij_avgust_september_oktober_november_december'.split('_'),
//	monthsShort: 'jan._feb._mar._apr._maj._jun._jul._avg._sep._okt._nov._dec.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'nedelja_ponedeljek_torek_sreda_četrtek_petek_sobota'.split('_'),
//	weekdaysShort: 'ned._pon._tor._sre._čet._pet._sob.'.split('_'),
//	weekdaysMin: 'ne_po_to_sr_če_pe_so'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY H:mm',
//	  LLLL: 'dddd, D. MMMM YYYY H:mm'
//	},
//	calendar: {
//	  sameDay: '[danes ob] LT',
//	  nextDay: '[jutri ob] LT',
//	  nextWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[v] [nedeljo] [ob] LT';
//		  case 3:
//			return '[v] [sredo] [ob] LT';
//		  case 6:
//			return '[v] [soboto] [ob] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//		  case 5:
//			return '[v] dddd [ob] LT'
//		}
//	  },
//	  lastDay: '[včeraj ob] LT',
//	  lastWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[prejšnjo] [nedeljo] [ob] LT';
//		  case 3:
//			return '[prejšnjo] [sredo] [ob] LT';
//		  case 6:
//			return '[prejšnjo] [soboto] [ob] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//		  case 5:
//			return '[prejšnji] dddd [ob] LT'
//		}
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'čez %s',
//	  past: 'pred %s',
//	  s: t,
//	  ss: t,
//	  m: t,
//	  mm: t,
//	  h: t,
//	  hh: t,
//	  d: t,
//	  dd: t,
//	  M: t,
//	  MM: t,
//	  y: t,
//	  yy: t
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('sq', {
//	months: 'Janar_Shkurt_Mars_Prill_Maj_Qershor_Korrik_Gusht_Shtator_Tetor_Nëntor_Dhjetor'.split('_'),
//	monthsShort: 'Jan_Shk_Mar_Pri_Maj_Qer_Kor_Gus_Sht_Tet_Nën_Dhj'.split('_'),
//	weekdays: 'E Diel_E Hënë_E Martë_E Mërkurë_E Enjte_E Premte_E Shtunë'.split('_'),
//	weekdaysShort: 'Die_Hën_Mar_Mër_Enj_Pre_Sht'.split('_'),
//	weekdaysMin: 'D_H_Ma_Më_E_P_Sh'.split('_'),
//	weekdaysParseExact: !0,
//	meridiemParse: /PD|MD/,
//	isPM: function (e) {
//	  return 'M' === e.charAt(0)
//	},
//	meridiem: function (e, t, n) {
//	  return e < 12 ? 'PD' : 'MD'
//	},
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Sot në] LT',
//	  nextDay: '[Nesër në] LT',
//	  nextWeek: 'dddd [në] LT',
//	  lastDay: '[Dje në] LT',
//	  lastWeek: 'dddd [e kaluar në] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'në %s',
//	  past: '%s më parë',
//	  s: 'disa sekonda',
//	  ss: '%d sekonda',
//	  m: 'një minutë',
//	  mm: '%d minuta',
//	  h: 'një orë',
//	  hh: '%d orë',
//	  d: 'një ditë',
//	  dd: '%d ditë',
//	  M: 'një muaj',
//	  MM: '%d muaj',
//	  y: 'një vit',
//	  yy: '%d vite'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	words: {
//	  ss: [
//		'sekunda',
//		'sekunde',
//		'sekundi'
//	  ],
//	  m: [
//		'jedan minut',
//		'jedne minute'
//	  ],
//	  mm: [
//		'minut',
//		'minute',
//		'minuta'
//	  ],
//	  h: [
//		'jedan sat',
//		'jednog sata'
//	  ],
//	  hh: [
//		'sat',
//		'sata',
//		'sati'
//	  ],
//	  dd: [
//		'dan',
//		'dana',
//		'dana'
//	  ],
//	  MM: [
//		'mesec',
//		'meseca',
//		'meseci'
//	  ],
//	  yy: [
//		'godina',
//		'godine',
//		'godina'
//	  ]
//	},
//	correctGrammaticalCase: function (e, t) {
//	  return 1 === e ? t[0] : e >= 2 && e <= 4 ? t[1] : t[2]
//	},
//	translate: function (e, n, r) {
//	  var a = t.words[r];
//	  return 1 === r.length ? n ? a[0] : a[1] : e + ' ' + t.correctGrammaticalCase(e, a)
//	}
//  };
//  return e.defineLocale('sr', {
//	months: 'januar_februar_mart_april_maj_jun_jul_avgust_septembar_oktobar_novembar_decembar'.split('_'),
//	monthsShort: 'jan._feb._mar._apr._maj_jun_jul_avg._sep._okt._nov._dec.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'nedelja_ponedeljak_utorak_sreda_četvrtak_petak_subota'.split('_'),
//	weekdaysShort: 'ned._pon._uto._sre._čet._pet._sub.'.split('_'),
//	weekdaysMin: 'ne_po_ut_sr_če_pe_su'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY H:mm',
//	  LLLL: 'dddd, D. MMMM YYYY H:mm'
//	},
//	calendar: {
//	  sameDay: '[danas u] LT',
//	  nextDay: '[sutra u] LT',
//	  nextWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[u] [nedelju] [u] LT';
//		  case 3:
//			return '[u] [sredu] [u] LT';
//		  case 6:
//			return '[u] [subotu] [u] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//		  case 5:
//			return '[u] dddd [u] LT'
//		}
//	  },
//	  lastDay: '[juče u] LT',
//	  lastWeek: function () {
//		return ['[prošle] [nedelje] [u] LT',
//		'[prošlog] [ponedeljka] [u] LT',
//		'[prošlog] [utorka] [u] LT',
//		'[prošle] [srede] [u] LT',
//		'[prošlog] [četvrtka] [u] LT',
//		'[prošlog] [petka] [u] LT',
//		'[prošle] [subote] [u] LT'][this.day()]
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'za %s',
//	  past: 'pre %s',
//	  s: 'nekoliko sekundi',
//	  ss: t.translate,
//	  m: t.translate,
//	  mm: t.translate,
//	  h: t.translate,
//	  hh: t.translate,
//	  d: 'dan',
//	  dd: t.translate,
//	  M: 'mesec',
//	  MM: t.translate,
//	  y: 'godinu',
//	  yy: t.translate
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	words: {
//	  ss: [
//		'секунда',
//		'секунде',
//		'секунди'
//	  ],
//	  m: [
//		'један минут',
//		'једне минуте'
//	  ],
//	  mm: [
//		'минут',
//		'минуте',
//		'минута'
//	  ],
//	  h: [
//		'један сат',
//		'једног сата'
//	  ],
//	  hh: [
//		'сат',
//		'сата',
//		'сати'
//	  ],
//	  dd: [
//		'дан',
//		'дана',
//		'дана'
//	  ],
//	  MM: [
//		'месец',
//		'месеца',
//		'месеци'
//	  ],
//	  yy: [
//		'година',
//		'године',
//		'година'
//	  ]
//	},
//	correctGrammaticalCase: function (e, t) {
//	  return 1 === e ? t[0] : e >= 2 && e <= 4 ? t[1] : t[2]
//	},
//	translate: function (e, n, r) {
//	  var a = t.words[r];
//	  return 1 === r.length ? n ? a[0] : a[1] : e + ' ' + t.correctGrammaticalCase(e, a)
//	}
//  };
//  return e.defineLocale('sr-cyrl', {
//	months: 'јануар_фебруар_март_април_мај_јун_јул_август_септембар_октобар_новембар_децембар'.split('_'),
//	monthsShort: 'јан._феб._мар._апр._мај_јун_јул_авг._сеп._окт._нов._дец.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'недеља_понедељак_уторак_среда_четвртак_петак_субота'.split('_'),
//	weekdaysShort: 'нед._пон._уто._сре._чет._пет._суб.'.split('_'),
//	weekdaysMin: 'не_по_ут_ср_че_пе_су'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM YYYY',
//	  LLL: 'D. MMMM YYYY H:mm',
//	  LLLL: 'dddd, D. MMMM YYYY H:mm'
//	},
//	calendar: {
//	  sameDay: '[данас у] LT',
//	  nextDay: '[сутра у] LT',
//	  nextWeek: function () {
//		switch (this.day()) {
//		  case 0:
//			return '[у] [недељу] [у] LT';
//		  case 3:
//			return '[у] [среду] [у] LT';
//		  case 6:
//			return '[у] [суботу] [у] LT';
//		  case 1:
//		  case 2:
//		  case 4:
//		  case 5:
//			return '[у] dddd [у] LT'
//		}
//	  },
//	  lastDay: '[јуче у] LT',
//	  lastWeek: function () {
//		return ['[прошле] [недеље] [у] LT',
//		'[прошлог] [понедељка] [у] LT',
//		'[прошлог] [уторка] [у] LT',
//		'[прошле] [среде] [у] LT',
//		'[прошлог] [четвртка] [у] LT',
//		'[прошлог] [петка] [у] LT',
//		'[прошле] [суботе] [у] LT'][this.day()]
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'за %s',
//	  past: 'пре %s',
//	  s: 'неколико секунди',
//	  ss: t.translate,
//	  m: t.translate,
//	  mm: t.translate,
//	  h: t.translate,
//	  hh: t.translate,
//	  d: 'дан',
//	  dd: t.translate,
//	  M: 'месец',
//	  MM: t.translate,
//	  y: 'годину',
//	  yy: t.translate
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('ss', {
//	months: 'Bhimbidvwane_Indlovana_Indlov\'lenkhulu_Mabasa_Inkhwekhweti_Inhlaba_Kholwane_Ingci_Inyoni_Imphala_Lweti_Ingongoni'.split('_'),
//	monthsShort: 'Bhi_Ina_Inu_Mab_Ink_Inh_Kho_Igc_Iny_Imp_Lwe_Igo'.split('_'),
//	weekdays: 'Lisontfo_Umsombuluko_Lesibili_Lesitsatfu_Lesine_Lesihlanu_Umgcibelo'.split('_'),
//	weekdaysShort: 'Lis_Umb_Lsb_Les_Lsi_Lsh_Umg'.split('_'),
//	weekdaysMin: 'Li_Us_Lb_Lt_Ls_Lh_Ug'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'h:mm A',
//	  LTS: 'h:mm:ss A',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY h:mm A',
//	  LLLL: 'dddd, D MMMM YYYY h:mm A'
//	},
//	calendar: {
//	  sameDay: '[Namuhla nga] LT',
//	  nextDay: '[Kusasa nga] LT',
//	  nextWeek: 'dddd [nga] LT',
//	  lastDay: '[Itolo nga] LT',
//	  lastWeek: 'dddd [leliphelile] [nga] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'nga %s',
//	  past: 'wenteka nga %s',
//	  s: 'emizuzwana lomcane',
//	  ss: '%d mzuzwana',
//	  m: 'umzuzu',
//	  mm: '%d emizuzu',
//	  h: 'lihora',
//	  hh: '%d emahora',
//	  d: 'lilanga',
//	  dd: '%d emalanga',
//	  M: 'inyanga',
//	  MM: '%d tinyanga',
//	  y: 'umnyaka',
//	  yy: '%d iminyaka'
//	},
//	meridiemParse: /ekuseni|emini|entsambama|ebusuku/,
//	meridiem: function (e, t, n) {
//	  return e < 11 ? 'ekuseni' : e < 15 ? 'emini' : e < 19 ? 'entsambama' : 'ebusuku'
//	},
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'ekuseni' === t ? e : 'emini' === t ? e >= 11 ? e : e + 12 : 'entsambama' === t || 'ebusuku' === t ? 0 === e ? 0 : e + 12 : void 0
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}/,
//	ordinal: '%d',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('sv', {
//	months: 'januari_februari_mars_april_maj_juni_juli_augusti_september_oktober_november_december'.split('_'),
//	monthsShort: 'jan_feb_mar_apr_maj_jun_jul_aug_sep_okt_nov_dec'.split('_'),
//	weekdays: 'söndag_måndag_tisdag_onsdag_torsdag_fredag_lördag'.split('_'),
//	weekdaysShort: 'sön_mån_tis_ons_tor_fre_lör'.split('_'),
//	weekdaysMin: 'sö_må_ti_on_to_fr_lö'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'YYYY-MM-DD',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY [kl.] HH:mm',
//	  LLLL: 'dddd D MMMM YYYY [kl.] HH:mm',
//	  lll: 'D MMM YYYY HH:mm',
//	  llll: 'ddd D MMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Idag] LT',
//	  nextDay: '[Imorgon] LT',
//	  lastDay: '[Igår] LT',
//	  nextWeek: '[På] dddd LT',
//	  lastWeek: '[I] dddd[s] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'om %s',
//	  past: 'för %s sedan',
//	  s: 'några sekunder',
//	  ss: '%d sekunder',
//	  m: 'en minut',
//	  mm: '%d minuter',
//	  h: 'en timme',
//	  hh: '%d timmar',
//	  d: 'en dag',
//	  dd: '%d dagar',
//	  M: 'en månad',
//	  MM: '%d månader',
//	  y: 'ett år',
//	  yy: '%d år'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(e|a)/,
//	ordinal: function (e) {
//	  var t = e % 10;
//	  return e + (1 == ~~(e % 100 / 10) ? 'e' : 1 === t ? 'a' : 2 === t ? 'a' : 'e')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('sw', {
//	months: 'Januari_Februari_Machi_Aprili_Mei_Juni_Julai_Agosti_Septemba_Oktoba_Novemba_Desemba'.split('_'),
//	monthsShort: 'Jan_Feb_Mac_Apr_Mei_Jun_Jul_Ago_Sep_Okt_Nov_Des'.split('_'),
//	weekdays: 'Jumapili_Jumatatu_Jumanne_Jumatano_Alhamisi_Ijumaa_Jumamosi'.split('_'),
//	weekdaysShort: 'Jpl_Jtat_Jnne_Jtan_Alh_Ijm_Jmos'.split('_'),
//	weekdaysMin: 'J2_J3_J4_J5_Al_Ij_J1'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[leo saa] LT',
//	  nextDay: '[kesho saa] LT',
//	  nextWeek: '[wiki ijayo] dddd [saat] LT',
//	  lastDay: '[jana] LT',
//	  lastWeek: '[wiki iliyopita] dddd [saat] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s baadaye',
//	  past: 'tokea %s',
//	  s: 'hivi punde',
//	  ss: 'sekunde %d',
//	  m: 'dakika moja',
//	  mm: 'dakika %d',
//	  h: 'saa limoja',
//	  hh: 'masaa %d',
//	  d: 'siku moja',
//	  dd: 'masiku %d',
//	  M: 'mwezi mmoja',
//	  MM: 'miezi %d',
//	  y: 'mwaka mmoja',
//	  yy: 'miaka %d'
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	1: '௧',
//	2: '௨',
//	3: '௩',
//	4: '௪',
//	5: '௫',
//	6: '௬',
//	7: '௭',
//	8: '௮',
//	9: '௯',
//	0: '௦'
//  },
//  n = {
//	'௧': '1',
//	'௨': '2',
//	'௩': '3',
//	'௪': '4',
//	'௫': '5',
//	'௬': '6',
//	'௭': '7',
//	'௮': '8',
//	'௯': '9',
//	'௦': '0'
//  };
//  return e.defineLocale('ta', {
//	months: 'ஜனவரி_பிப்ரவரி_மார்ச்_ஏப்ரல்_மே_ஜூன்_ஜூலை_ஆகஸ்ட்_செப்டெம்பர்_அக்டோபர்_நவம்பர்_டிசம்பர்'.split('_'),
//	monthsShort: 'ஜனவரி_பிப்ரவரி_மார்ச்_ஏப்ரல்_மே_ஜூன்_ஜூலை_ஆகஸ்ட்_செப்டெம்பர்_அக்டோபர்_நவம்பர்_டிசம்பர்'.split('_'),
//	weekdays: 'ஞாயிற்றுக்கிழமை_திங்கட்கிழமை_செவ்வாய்கிழமை_புதன்கிழமை_வியாழக்கிழமை_வெள்ளிக்கிழமை_சனிக்கிழமை'.split('_'),
//	weekdaysShort: 'ஞாயிறு_திங்கள்_செவ்வாய்_புதன்_வியாழன்_வெள்ளி_சனி'.split('_'),
//	weekdaysMin: 'ஞா_தி_செ_பு_வி_வெ_ச'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY, HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY, HH:mm'
//	},
//	calendar: {
//	  sameDay: '[இன்று] LT',
//	  nextDay: '[நாளை] LT',
//	  nextWeek: 'dddd, LT',
//	  lastDay: '[நேற்று] LT',
//	  lastWeek: '[கடந்த வாரம்] dddd, LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s இல்',
//	  past: '%s முன்',
//	  s: 'ஒரு சில விநாடிகள்',
//	  ss: '%d விநாடிகள்',
//	  m: 'ஒரு நிமிடம்',
//	  mm: '%d நிமிடங்கள்',
//	  h: 'ஒரு மணி நேரம்',
//	  hh: '%d மணி நேரம்',
//	  d: 'ஒரு நாள்',
//	  dd: '%d நாட்கள்',
//	  M: 'ஒரு மாதம்',
//	  MM: '%d மாதங்கள்',
//	  y: 'ஒரு வருடம்',
//	  yy: '%d ஆண்டுகள்'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}வது/,
//	ordinal: function (e) {
//	  return e + 'வது'
//	},
//	preparse: function (e) {
//	  return e.replace(/[௧௨௩௪௫௬௭௮௯௦]/g, function (e) {
//		return n[e]
//	  })
//	},
//	postformat: function (e) {
//	  return e.replace(/\d/g, function (e) {
//		return t[e]
//	  })
//	},
//	meridiemParse: /யாமம்|வைகறை|காலை|நண்பகல்|எற்பாடு|மாலை/,
//	meridiem: function (e, t, n) {
//	  return e < 2 ? ' யாமம்' : e < 6 ? ' வைகறை' : e < 10 ? ' காலை' : e < 14 ? ' நண்பகல்' : e < 18 ? ' எற்பாடு' : e < 22 ? ' மாலை' : ' யாமம்'
//	},
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'யாமம்' === t ? e < 2 ? e : e + 12 : 'வைகறை' === t || 'காலை' === t ? e : 'நண்பகல்' === t && e >= 10 ? e : e + 12
//	},
//	week: {
//	  dow: 0,
//	  doy: 6
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('te', {
//	months: 'జనవరి_ఫిబ్రవరి_మార్చి_ఏప్రిల్_మే_జూన్_జూలై_ఆగస్టు_సెప్టెంబర్_అక్టోబర్_నవంబర్_డిసెంబర్'.split('_'),
//	monthsShort: 'జన._ఫిబ్ర._మార్చి_ఏప్రి._మే_జూన్_జూలై_ఆగ._సెప్._అక్టో._నవ._డిసె.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'ఆదివారం_సోమవారం_మంగళవారం_బుధవారం_గురువారం_శుక్రవారం_శనివారం'.split('_'),
//	weekdaysShort: 'ఆది_సోమ_మంగళ_బుధ_గురు_శుక్ర_శని'.split('_'),
//	weekdaysMin: 'ఆ_సో_మం_బు_గు_శు_శ'.split('_'),
//	longDateFormat: {
//	  LT: 'A h:mm',
//	  LTS: 'A h:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY, A h:mm',
//	  LLLL: 'dddd, D MMMM YYYY, A h:mm'
//	},
//	calendar: {
//	  sameDay: '[నేడు] LT',
//	  nextDay: '[రేపు] LT',
//	  nextWeek: 'dddd, LT',
//	  lastDay: '[నిన్న] LT',
//	  lastWeek: '[గత] dddd, LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s లో',
//	  past: '%s క్రితం',
//	  s: 'కొన్ని క్షణాలు',
//	  ss: '%d సెకన్లు',
//	  m: 'ఒక నిమిషం',
//	  mm: '%d నిమిషాలు',
//	  h: 'ఒక గంట',
//	  hh: '%d గంటలు',
//	  d: 'ఒక రోజు',
//	  dd: '%d రోజులు',
//	  M: 'ఒక నెల',
//	  MM: '%d నెలలు',
//	  y: 'ఒక సంవత్సరం',
//	  yy: '%d సంవత్సరాలు'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}వ/,
//	ordinal: '%dవ',
//	meridiemParse: /రాత్రి|ఉదయం|మధ్యాహ్నం|సాయంత్రం/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  'రాత్రి' === t ? e < 4 ? e : e + 12 : 'ఉదయం' === t ? e : 'మధ్యాహ్నం' === t ? e >= 10 ? e : e + 12 : 'సాయంత్రం' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  return e < 4 ? 'రాత్రి' : e < 10 ? 'ఉదయం' : e < 17 ? 'మధ్యాహ్నం' : e < 20 ? 'సాయంత్రం' : 'రాత్రి'
//	},
//	week: {
//	  dow: 0,
//	  doy: 6
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('tet', {
//	months: 'Janeiru_Fevereiru_Marsu_Abril_Maiu_Juniu_Juliu_Augustu_Setembru_Outubru_Novembru_Dezembru'.split('_'),
//	monthsShort: 'Jan_Fev_Mar_Abr_Mai_Jun_Jul_Aug_Set_Out_Nov_Dez'.split('_'),
//	weekdays: 'Domingu_Segunda_Tersa_Kuarta_Kinta_Sexta_Sabadu'.split('_'),
//	weekdaysShort: 'Dom_Seg_Ters_Kua_Kint_Sext_Sab'.split('_'),
//	weekdaysMin: 'Do_Seg_Te_Ku_Ki_Sex_Sa'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Ohin iha] LT',
//	  nextDay: '[Aban iha] LT',
//	  nextWeek: 'dddd [iha] LT',
//	  lastDay: '[Horiseik iha] LT',
//	  lastWeek: 'dddd [semana kotuk] [iha] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'iha %s',
//	  past: '%s liuba',
//	  s: 'minutu balun',
//	  ss: 'minutu %d',
//	  m: 'minutu ida',
//	  mm: 'minutus %d',
//	  h: 'horas ida',
//	  hh: 'horas %d',
//	  d: 'loron ida',
//	  dd: 'loron %d',
//	  M: 'fulan ida',
//	  MM: 'fulan %d',
//	  y: 'tinan ida',
//	  yy: 'tinan %d'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(st|nd|rd|th)/,
//	ordinal: function (e) {
//	  var t = e % 10;
//	  return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('th', {
//	months: 'มกราคม_กุมภาพันธ์_มีนาคม_เมษายน_พฤษภาคม_มิถุนายน_กรกฎาคม_สิงหาคม_กันยายน_ตุลาคม_พฤศจิกายน_ธันวาคม'.split('_'),
//	monthsShort: 'ม.ค._ก.พ._มี.ค._เม.ย._พ.ค._มิ.ย._ก.ค._ส.ค._ก.ย._ต.ค._พ.ย._ธ.ค.'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'อาทิตย์_จันทร์_อังคาร_พุธ_พฤหัสบดี_ศุกร์_เสาร์'.split('_'),
//	weekdaysShort: 'อาทิตย์_จันทร์_อังคาร_พุธ_พฤหัส_ศุกร์_เสาร์'.split('_'),
//	weekdaysMin: 'อา._จ._อ._พ._พฤ._ศ._ส.'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'H:mm',
//	  LTS: 'H:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY เวลา H:mm',
//	  LLLL: 'วันddddที่ D MMMM YYYY เวลา H:mm'
//	},
//	meridiemParse: /ก่อนเที่ยง|หลังเที่ยง/,
//	isPM: function (e) {
//	  return 'หลังเที่ยง' === e
//	},
//	meridiem: function (e, t, n) {
//	  return e < 12 ? 'ก่อนเที่ยง' : 'หลังเที่ยง'
//	},
//	calendar: {
//	  sameDay: '[วันนี้ เวลา] LT',
//	  nextDay: '[พรุ่งนี้ เวลา] LT',
//	  nextWeek: 'dddd[หน้า เวลา] LT',
//	  lastDay: '[เมื่อวานนี้ เวลา] LT',
//	  lastWeek: '[วัน]dddd[ที่แล้ว เวลา] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'อีก %s',
//	  past: '%sที่แล้ว',
//	  s: 'ไม่กี่วินาที',
//	  ss: '%d วินาที',
//	  m: '1 นาที',
//	  mm: '%d นาที',
//	  h: '1 ชั่วโมง',
//	  hh: '%d ชั่วโมง',
//	  d: '1 วัน',
//	  dd: '%d วัน',
//	  M: '1 เดือน',
//	  MM: '%d เดือน',
//	  y: '1 ปี',
//	  yy: '%d ปี'
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('tl-ph', {
//	months: 'Enero_Pebrero_Marso_Abril_Mayo_Hunyo_Hulyo_Agosto_Setyembre_Oktubre_Nobyembre_Disyembre'.split('_'),
//	monthsShort: 'Ene_Peb_Mar_Abr_May_Hun_Hul_Ago_Set_Okt_Nob_Dis'.split('_'),
//	weekdays: 'Linggo_Lunes_Martes_Miyerkules_Huwebes_Biyernes_Sabado'.split('_'),
//	weekdaysShort: 'Lin_Lun_Mar_Miy_Huw_Biy_Sab'.split('_'),
//	weekdaysMin: 'Li_Lu_Ma_Mi_Hu_Bi_Sab'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'MM/D/YYYY',
//	  LL: 'MMMM D, YYYY',
//	  LLL: 'MMMM D, YYYY HH:mm',
//	  LLLL: 'dddd, MMMM DD, YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: 'LT [ngayong araw]',
//	  nextDay: '[Bukas ng] LT',
//	  nextWeek: 'LT [sa susunod na] dddd',
//	  lastDay: 'LT [kahapon]',
//	  lastWeek: 'LT [noong nakaraang] dddd',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'sa loob ng %s',
//	  past: '%s ang nakalipas',
//	  s: 'ilang segundo',
//	  ss: '%d segundo',
//	  m: 'isang minuto',
//	  mm: '%d minuto',
//	  h: 'isang oras',
//	  hh: '%d oras',
//	  d: 'isang araw',
//	  dd: '%d araw',
//	  M: 'isang buwan',
//	  MM: '%d buwan',
//	  y: 'isang taon',
//	  yy: '%d taon'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}/,
//	ordinal: function (e) {
//	  return e
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e) {
//	var t = e;
//	return t = - 1 !== e.indexOf('jaj') ? t.slice(0, - 3) + 'leS' : - 1 !== e.indexOf('jar') ? t.slice(0, - 3) + 'waQ' : - 1 !== e.indexOf('DIS') ? t.slice(0, - 3) + 'nem' : t + ' pIq'
//  }
//  function n(e) {
//	var t = e;
//	return t = - 1 !== e.indexOf('jaj') ? t.slice(0, - 3) + 'Hu’' : - 1 !== e.indexOf('jar') ? t.slice(0, - 3) + 'wen' : - 1 !== e.indexOf('DIS') ? t.slice(0, - 3) + 'ben' : t + ' ret'
//  }
//  function r(e, t, n, r) {
//	var o = a(e);
//	switch (n) {
//	  case 'ss':
//		return o + ' lup';
//	  case 'mm':
//		return o + ' tup';
//	  case 'hh':
//		return o + ' rep';
//	  case 'dd':
//		return o + ' jaj';
//	  case 'MM':
//		return o + ' jar';
//	  case 'yy':
//		return o + ' DIS'
//	}
//  }
//  function a(e) {
//	var t = Math.floor(e % 1000 / 100),
//	n = Math.floor(e % 100 / 10),
//	r = e % 10,
//	a = '';
//	return t > 0 && (a += o[t] + 'vatlh'),
//	n > 0 && (a += ('' !== a ? ' ' : '') + o[n] + 'maH'),
//	r > 0 && (a += ('' !== a ? ' ' : '') + o[r]),
//	'' === a ? 'pagh' : a
//  }
//  var o = 'pagh_wa’_cha’_wej_loS_vagh_jav_Soch_chorgh_Hut'.split('_');
//  return e.defineLocale('tlh', {
//	months: 'tera’ jar wa’_tera’ jar cha’_tera’ jar wej_tera’ jar loS_tera’ jar vagh_tera’ jar jav_tera’ jar Soch_tera’ jar chorgh_tera’ jar Hut_tera’ jar wa’maH_tera’ jar wa’maH wa’_tera’ jar wa’maH cha’'.split('_'),
//	monthsShort: 'jar wa’_jar cha’_jar wej_jar loS_jar vagh_jar jav_jar Soch_jar chorgh_jar Hut_jar wa’maH_jar wa’maH wa’_jar wa’maH cha’'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'lojmItjaj_DaSjaj_povjaj_ghItlhjaj_loghjaj_buqjaj_ghInjaj'.split('_'),
//	weekdaysShort: 'lojmItjaj_DaSjaj_povjaj_ghItlhjaj_loghjaj_buqjaj_ghInjaj'.split('_'),
//	weekdaysMin: 'lojmItjaj_DaSjaj_povjaj_ghItlhjaj_loghjaj_buqjaj_ghInjaj'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[DaHjaj] LT',
//	  nextDay: '[wa’leS] LT',
//	  nextWeek: 'LLL',
//	  lastDay: '[wa’Hu’] LT',
//	  lastWeek: 'LLL',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: t,
//	  past: n,
//	  s: 'puS lup',
//	  ss: r,
//	  m: 'wa’ tup',
//	  mm: r,
//	  h: 'wa’ rep',
//	  hh: r,
//	  d: 'wa’ jaj',
//	  dd: r,
//	  M: 'wa’ jar',
//	  MM: r,
//	  y: 'wa’ DIS',
//	  yy: r
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = {
//	1: '\'inci',
//	5: '\'inci',
//	8: '\'inci',
//	70: '\'inci',
//	80: '\'inci',
//	2: '\'nci',
//	7: '\'nci',
//	20: '\'nci',
//	50: '\'nci',
//	3: '\'üncü',
//	4: '\'üncü',
//	100: '\'üncü',
//	6: '\'ncı',
//	9: '\'uncu',
//	10: '\'uncu',
//	30: '\'uncu',
//	60: '\'ıncı',
//	90: '\'ıncı'
//  };
//  return e.defineLocale('tr', {
//	months: 'Ocak_Şubat_Mart_Nisan_Mayıs_Haziran_Temmuz_Ağustos_Eylül_Ekim_Kasım_Aralık'.split('_'),
//	monthsShort: 'Oca_Şub_Mar_Nis_May_Haz_Tem_Ağu_Eyl_Eki_Kas_Ara'.split('_'),
//	weekdays: 'Pazar_Pazartesi_Salı_Çarşamba_Perşembe_Cuma_Cumartesi'.split('_'),
//	weekdaysShort: 'Paz_Pts_Sal_Çar_Per_Cum_Cts'.split('_'),
//	weekdaysMin: 'Pz_Pt_Sa_Ça_Pe_Cu_Ct'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[bugün saat] LT',
//	  nextDay: '[yarın saat] LT',
//	  nextWeek: '[gelecek] dddd [saat] LT',
//	  lastDay: '[dün] LT',
//	  lastWeek: '[geçen] dddd [saat] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s sonra',
//	  past: '%s önce',
//	  s: 'birkaç saniye',
//	  ss: '%d saniye',
//	  m: 'bir dakika',
//	  mm: '%d dakika',
//	  h: 'bir saat',
//	  hh: '%d saat',
//	  d: 'bir gün',
//	  dd: '%d gün',
//	  M: 'bir ay',
//	  MM: '%d ay',
//	  y: 'bir yıl',
//	  yy: '%d yıl'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}'(inci|nci|üncü|ncı|uncu|ıncı)/,
//	ordinal: function (e) {
//	  if (0 === e) return e + '\'ıncı';
//	  var n = e % 10,
//	  r = e % 100 - n,
//	  a = e >= 100 ? 100 : null;
//	  return e + (t[n] || t[r] || t[a])
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e, t, n, r) {
//	var a = {
//	  s: [
//		'viensas secunds',
//		'\'iensas secunds'
//	  ],
//	  ss: [
//		e + ' secunds',
//		e + ' secunds'
//	  ],
//	  m: [
//		'\'n míut',
//		'\'iens míut'
//	  ],
//	  mm: [
//		e + ' míuts',
//		e + ' míuts'
//	  ],
//	  h: [
//		'\'n þora',
//		'\'iensa þora'
//	  ],
//	  hh: [
//		e + ' þoras',
//		e + ' þoras'
//	  ],
//	  d: [
//		'\'n ziua',
//		'\'iensa ziua'
//	  ],
//	  dd: [
//		e + ' ziuas',
//		e + ' ziuas'
//	  ],
//	  M: [
//		'\'n mes',
//		'\'iens mes'
//	  ],
//	  MM: [
//		e + ' mesen',
//		e + ' mesen'
//	  ],
//	  y: [
//		'\'n ar',
//		'\'iens ar'
//	  ],
//	  yy: [
//		e + ' ars',
//		e + ' ars'
//	  ]
//	};
//	return r ? a[n][0] : t ? a[n][0] : a[n][1]
//  }
//  return e.defineLocale('tzl', {
//	months: 'Januar_Fevraglh_Març_Avrïu_Mai_Gün_Julia_Guscht_Setemvar_Listopäts_Noemvar_Zecemvar'.split('_'),
//	monthsShort: 'Jan_Fev_Mar_Avr_Mai_Gün_Jul_Gus_Set_Lis_Noe_Zec'.split('_'),
//	weekdays: 'Súladi_Lúneçi_Maitzi_Márcuri_Xhúadi_Viénerçi_Sáturi'.split('_'),
//	weekdaysShort: 'Súl_Lún_Mai_Már_Xhú_Vié_Sát'.split('_'),
//	weekdaysMin: 'Sú_Lú_Ma_Má_Xh_Vi_Sá'.split('_'),
//	longDateFormat: {
//	  LT: 'HH.mm',
//	  LTS: 'HH.mm.ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D. MMMM [dallas] YYYY',
//	  LLL: 'D. MMMM [dallas] YYYY HH.mm',
//	  LLLL: 'dddd, [li] D. MMMM [dallas] YYYY HH.mm'
//	},
//	meridiemParse: /d\'o|d\'a/i,
//	isPM: function (e) {
//	  return 'd\'o' === e.toLowerCase()
//	},
//	meridiem: function (e, t, n) {
//	  return e > 11 ? n ? 'd\'o' : 'D\'O' : n ? 'd\'a' : 'D\'A'
//	},
//	calendar: {
//	  sameDay: '[oxhi à] LT',
//	  nextDay: '[demà à] LT',
//	  nextWeek: 'dddd [à] LT',
//	  lastDay: '[ieiri à] LT',
//	  lastWeek: '[sür el] dddd [lasteu à] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'osprei %s',
//	  past: 'ja%s',
//	  s: t,
//	  ss: t,
//	  m: t,
//	  mm: t,
//	  h: t,
//	  hh: t,
//	  d: t,
//	  dd: t,
//	  M: t,
//	  MM: t,
//	  y: t,
//	  yy: t
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}\./,
//	ordinal: '%d.',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('tzm', {
//	months: 'ⵉⵏⵏⴰⵢⵔ_ⴱⵕⴰⵢⵕ_ⵎⴰⵕⵚ_ⵉⴱⵔⵉⵔ_ⵎⴰⵢⵢⵓ_ⵢⵓⵏⵢⵓ_ⵢⵓⵍⵢⵓⵣ_ⵖⵓⵛⵜ_ⵛⵓⵜⴰⵏⴱⵉⵔ_ⴽⵟⵓⴱⵕ_ⵏⵓⵡⴰⵏⴱⵉⵔ_ⴷⵓⵊⵏⴱⵉⵔ'.split('_'),
//	monthsShort: 'ⵉⵏⵏⴰⵢⵔ_ⴱⵕⴰⵢⵕ_ⵎⴰⵕⵚ_ⵉⴱⵔⵉⵔ_ⵎⴰⵢⵢⵓ_ⵢⵓⵏⵢⵓ_ⵢⵓⵍⵢⵓⵣ_ⵖⵓⵛⵜ_ⵛⵓⵜⴰⵏⴱⵉⵔ_ⴽⵟⵓⴱⵕ_ⵏⵓⵡⴰⵏⴱⵉⵔ_ⴷⵓⵊⵏⴱⵉⵔ'.split('_'),
//	weekdays: 'ⴰⵙⴰⵎⴰⵙ_ⴰⵢⵏⴰⵙ_ⴰⵙⵉⵏⴰⵙ_ⴰⴽⵔⴰⵙ_ⴰⴽⵡⴰⵙ_ⴰⵙⵉⵎⵡⴰⵙ_ⴰⵙⵉⴹⵢⴰⵙ'.split('_'),
//	weekdaysShort: 'ⴰⵙⴰⵎⴰⵙ_ⴰⵢⵏⴰⵙ_ⴰⵙⵉⵏⴰⵙ_ⴰⴽⵔⴰⵙ_ⴰⴽⵡⴰⵙ_ⴰⵙⵉⵎⵡⴰⵙ_ⴰⵙⵉⴹⵢⴰⵙ'.split('_'),
//	weekdaysMin: 'ⴰⵙⴰⵎⴰⵙ_ⴰⵢⵏⴰⵙ_ⴰⵙⵉⵏⴰⵙ_ⴰⴽⵔⴰⵙ_ⴰⴽⵡⴰⵙ_ⴰⵙⵉⵎⵡⴰⵙ_ⴰⵙⵉⴹⵢⴰⵙ'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[ⴰⵙⴷⵅ ⴴ] LT',
//	  nextDay: '[ⴰⵙⴽⴰ ⴴ] LT',
//	  nextWeek: 'dddd [ⴴ] LT',
//	  lastDay: '[ⴰⵚⴰⵏⵜ ⴴ] LT',
//	  lastWeek: 'dddd [ⴴ] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'ⴷⴰⴷⵅ ⵙ ⵢⴰⵏ %s',
//	  past: 'ⵢⴰⵏ %s',
//	  s: 'ⵉⵎⵉⴽ',
//	  ss: '%d ⵉⵎⵉⴽ',
//	  m: 'ⵎⵉⵏⵓⴺ',
//	  mm: '%d ⵎⵉⵏⵓⴺ',
//	  h: 'ⵙⴰⵄⴰ',
//	  hh: '%d ⵜⴰⵙⵙⴰⵄⵉⵏ',
//	  d: 'ⴰⵙⵙ',
//	  dd: '%d oⵙⵙⴰⵏ',
//	  M: 'ⴰⵢoⵓⵔ',
//	  MM: '%d ⵉⵢⵢⵉⵔⵏ',
//	  y: 'ⴰⵙⴳⴰⵙ',
//	  yy: '%d ⵉⵙⴳⴰⵙⵏ'
//	},
//	week: {
//	  dow: 6,
//	  doy: 12
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('tzm-latn', {
//	months: 'innayr_brˤayrˤ_marˤsˤ_ibrir_mayyw_ywnyw_ywlywz_ɣwšt_šwtanbir_ktˤwbrˤ_nwwanbir_dwjnbir'.split('_'),
//	monthsShort: 'innayr_brˤayrˤ_marˤsˤ_ibrir_mayyw_ywnyw_ywlywz_ɣwšt_šwtanbir_ktˤwbrˤ_nwwanbir_dwjnbir'.split('_'),
//	weekdays: 'asamas_aynas_asinas_akras_akwas_asimwas_asiḍyas'.split('_'),
//	weekdaysShort: 'asamas_aynas_asinas_akras_akwas_asimwas_asiḍyas'.split('_'),
//	weekdaysMin: 'asamas_aynas_asinas_akras_akwas_asimwas_asiḍyas'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[asdkh g] LT',
//	  nextDay: '[aska g] LT',
//	  nextWeek: 'dddd [g] LT',
//	  lastDay: '[assant g] LT',
//	  lastWeek: 'dddd [g] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'dadkh s yan %s',
//	  past: 'yan %s',
//	  s: 'imik',
//	  ss: '%d imik',
//	  m: 'minuḍ',
//	  mm: '%d minuḍ',
//	  h: 'saɛa',
//	  hh: '%d tassaɛin',
//	  d: 'ass',
//	  dd: '%d ossan',
//	  M: 'ayowr',
//	  MM: '%d iyyirn',
//	  y: 'asgas',
//	  yy: '%d isgasn'
//	},
//	week: {
//	  dow: 6,
//	  doy: 12
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  function t(e, t) {
//	var n = e.split('_');
//	return t % 10 == 1 && t % 100 != 11 ? n[0] : t % 10 >= 2 && t % 10 <= 4 && (t % 100 < 10 || t % 100 >= 20) ? n[1] : n[2]
//  }
//  function n(e, n, r) {
//	var a = {
//	  ss: n ? 'секунда_секунди_секунд' : 'секунду_секунди_секунд',
//	  mm: n ? 'хвилина_хвилини_хвилин' : 'хвилину_хвилини_хвилин',
//	  hh: n ? 'година_години_годин' : 'годину_години_годин',
//	  dd: 'день_дні_днів',
//	  MM: 'місяць_місяці_місяців',
//	  yy: 'рік_роки_років'
//	};
//	return 'm' === r ? n ? 'хвилина' : 'хвилину' : 'h' === r ? n ? 'година' : 'годину' : e + ' ' + t(a[r], + e)
//  }
//  function r(e, t) {
//	var n = {
//	  nominative: 'неділя_понеділок_вівторок_середа_четвер_п’ятниця_субота'.split('_'),
//	  accusative: 'неділю_понеділок_вівторок_середу_четвер_п’ятницю_суботу'.split('_'),
//	  genitive: 'неділі_понеділка_вівторка_середи_четверга_п’ятниці_суботи'.split('_')
//	};
//	return e ? n[/(\[[ВвУу]\]) ?dddd/.test(t) ? 'accusative' : /\[?(?:минулої|наступної)? ?\] ?dddd/.test(t) ? 'genitive' : 'nominative'][e.day()] : n.nominative
//  }
//  function a(e) {
//	return function () {
//	  return e + 'о' + (11 === this.hours() ? 'б' : '') + '] LT'
//	}
//  }
//  return e.defineLocale('uk', {
//	months: {
//	  format: 'січня_лютого_березня_квітня_травня_червня_липня_серпня_вересня_жовтня_листопада_грудня'.split('_'),
//	  standalone: 'січень_лютий_березень_квітень_травень_червень_липень_серпень_вересень_жовтень_листопад_грудень'.split('_')
//	},
//	monthsShort: 'січ_лют_бер_квіт_трав_черв_лип_серп_вер_жовт_лист_груд'.split('_'),
//	weekdays: r,
//	weekdaysShort: 'нд_пн_вт_ср_чт_пт_сб'.split('_'),
//	weekdaysMin: 'нд_пн_вт_ср_чт_пт_сб'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD.MM.YYYY',
//	  LL: 'D MMMM YYYY р.',
//	  LLL: 'D MMMM YYYY р., HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY р., HH:mm'
//	},
//	calendar: {
//	  sameDay: a('[Сьогодні '),
//	  nextDay: a('[Завтра '),
//	  lastDay: a('[Вчора '),
//	  nextWeek: a('[У] dddd ['),
//	  lastWeek: function () {
//		switch (this.day()) {
//		  case 0:
//		  case 3:
//		  case 5:
//		  case 6:
//			return a('[Минулої] dddd [').call(this);
//		  case 1:
//		  case 2:
//		  case 4:
//			return a('[Минулого] dddd [').call(this)
//		}
//	  },
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'за %s',
//	  past: '%s тому',
//	  s: 'декілька секунд',
//	  ss: n,
//	  m: n,
//	  mm: n,
//	  h: 'годину',
//	  hh: n,
//	  d: 'день',
//	  dd: n,
//	  M: 'місяць',
//	  MM: n,
//	  y: 'рік',
//	  yy: n
//	},
//	meridiemParse: /ночі|ранку|дня|вечора/,
//	isPM: function (e) {
//	  return /^(дня|вечора)$/.test(e)
//	},
//	meridiem: function (e, t, n) {
//	  return e < 4 ? 'ночі' : e < 12 ? 'ранку' : e < 17 ? 'дня' : 'вечора'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}-(й|го)/,
//	ordinal: function (e, t) {
//	  switch (t) {
//		case 'M':
//		case 'd':
//		case 'DDD':
//		case 'w':
//		case 'W':
//		  return e + '-й';
//		case 'D':
//		  return e + '-го';
//		default:
//		  return e
//	  }
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  var t = [
//	'جنوری',
//	'فروری',
//	'مارچ',
//	'اپریل',
//	'مئی',
//	'جون',
//	'جولائی',
//	'اگست',
//	'ستمبر',
//	'اکتوبر',
//	'نومبر',
//	'دسمبر'
//  ],
//  n = [
//	'اتوار',
//	'پیر',
//	'منگل',
//	'بدھ',
//	'جمعرات',
//	'جمعہ',
//	'ہفتہ'
//  ];
//  return e.defineLocale('ur', {
//	months: t,
//	monthsShort: t,
//	weekdays: n,
//	weekdaysShort: n,
//	weekdaysMin: n,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd، D MMMM YYYY HH:mm'
//	},
//	meridiemParse: /صبح|شام/,
//	isPM: function (e) {
//	  return 'شام' === e
//	},
//	meridiem: function (e, t, n) {
//	  return e < 12 ? 'صبح' : 'شام'
//	},
//	calendar: {
//	  sameDay: '[آج بوقت] LT',
//	  nextDay: '[کل بوقت] LT',
//	  nextWeek: 'dddd [بوقت] LT',
//	  lastDay: '[گذشتہ روز بوقت] LT',
//	  lastWeek: '[گذشتہ] dddd [بوقت] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s بعد',
//	  past: '%s قبل',
//	  s: 'چند سیکنڈ',
//	  ss: '%d سیکنڈ',
//	  m: 'ایک منٹ',
//	  mm: '%d منٹ',
//	  h: 'ایک گھنٹہ',
//	  hh: '%d گھنٹے',
//	  d: 'ایک دن',
//	  dd: '%d دن',
//	  M: 'ایک ماہ',
//	  MM: '%d ماہ',
//	  y: 'ایک سال',
//	  yy: '%d سال'
//	},
//	preparse: function (e) {
//	  return e.replace(/،/g, ',')
//	},
//	postformat: function (e) {
//	  return e.replace(/,/g, '،')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('uz', {
//	months: 'январ_феврал_март_апрел_май_июн_июл_август_сентябр_октябр_ноябр_декабр'.split('_'),
//	monthsShort: 'янв_фев_мар_апр_май_июн_июл_авг_сен_окт_ноя_дек'.split('_'),
//	weekdays: 'Якшанба_Душанба_Сешанба_Чоршанба_Пайшанба_Жума_Шанба'.split('_'),
//	weekdaysShort: 'Якш_Душ_Сеш_Чор_Пай_Жум_Шан'.split('_'),
//	weekdaysMin: 'Як_Ду_Се_Чо_Па_Жу_Ша'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'D MMMM YYYY, dddd HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Бугун соат] LT [да]',
//	  nextDay: '[Эртага] LT [да]',
//	  nextWeek: 'dddd [куни соат] LT [да]',
//	  lastDay: '[Кеча соат] LT [да]',
//	  lastWeek: '[Утган] dddd [куни соат] LT [да]',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'Якин %s ичида',
//	  past: 'Бир неча %s олдин',
//	  s: 'фурсат',
//	  ss: '%d фурсат',
//	  m: 'бир дакика',
//	  mm: '%d дакика',
//	  h: 'бир соат',
//	  hh: '%d соат',
//	  d: 'бир кун',
//	  dd: '%d кун',
//	  M: 'бир ой',
//	  MM: '%d ой',
//	  y: 'бир йил',
//	  yy: '%d йил'
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('uz-latn', {
//	months: 'Yanvar_Fevral_Mart_Aprel_May_Iyun_Iyul_Avgust_Sentabr_Oktabr_Noyabr_Dekabr'.split('_'),
//	monthsShort: 'Yan_Fev_Mar_Apr_May_Iyun_Iyul_Avg_Sen_Okt_Noy_Dek'.split('_'),
//	weekdays: 'Yakshanba_Dushanba_Seshanba_Chorshanba_Payshanba_Juma_Shanba'.split('_'),
//	weekdaysShort: 'Yak_Dush_Sesh_Chor_Pay_Jum_Shan'.split('_'),
//	weekdaysMin: 'Ya_Du_Se_Cho_Pa_Ju_Sha'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'D MMMM YYYY, dddd HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Bugun soat] LT [da]',
//	  nextDay: '[Ertaga] LT [da]',
//	  nextWeek: 'dddd [kuni soat] LT [da]',
//	  lastDay: '[Kecha soat] LT [da]',
//	  lastWeek: '[O\'tgan] dddd [kuni soat] LT [da]',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'Yaqin %s ichida',
//	  past: 'Bir necha %s oldin',
//	  s: 'soniya',
//	  ss: '%d soniya',
//	  m: 'bir daqiqa',
//	  mm: '%d daqiqa',
//	  h: 'bir soat',
//	  hh: '%d soat',
//	  d: 'bir kun',
//	  dd: '%d kun',
//	  M: 'bir oy',
//	  MM: '%d oy',
//	  y: 'bir yil',
//	  yy: '%d yil'
//	},
//	week: {
//	  dow: 1,
//	  doy: 7
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('vi', {
//	months: 'tháng 1_tháng 2_tháng 3_tháng 4_tháng 5_tháng 6_tháng 7_tháng 8_tháng 9_tháng 10_tháng 11_tháng 12'.split('_'),
//	monthsShort: 'Th01_Th02_Th03_Th04_Th05_Th06_Th07_Th08_Th09_Th10_Th11_Th12'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'chủ nhật_thứ hai_thứ ba_thứ tư_thứ năm_thứ sáu_thứ bảy'.split('_'),
//	weekdaysShort: 'CN_T2_T3_T4_T5_T6_T7'.split('_'),
//	weekdaysMin: 'CN_T2_T3_T4_T5_T6_T7'.split('_'),
//	weekdaysParseExact: !0,
//	meridiemParse: /sa|ch/i,
//	isPM: function (e) {
//	  return /^ch$/i.test(e)
//	},
//	meridiem: function (e, t, n) {
//	  return e < 12 ? n ? 'sa' : 'SA' : n ? 'ch' : 'CH'
//	},
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM [năm] YYYY',
//	  LLL: 'D MMMM [năm] YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM [năm] YYYY HH:mm',
//	  l: 'DD/M/YYYY',
//	  ll: 'D MMM YYYY',
//	  lll: 'D MMM YYYY HH:mm',
//	  llll: 'ddd, D MMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[Hôm nay lúc] LT',
//	  nextDay: '[Ngày mai lúc] LT',
//	  nextWeek: 'dddd [tuần tới lúc] LT',
//	  lastDay: '[Hôm qua lúc] LT',
//	  lastWeek: 'dddd [tuần rồi lúc] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: '%s tới',
//	  past: '%s trước',
//	  s: 'vài giây',
//	  ss: '%d giây',
//	  m: 'một phút',
//	  mm: '%d phút',
//	  h: 'một giờ',
//	  hh: '%d giờ',
//	  d: 'một ngày',
//	  dd: '%d ngày',
//	  M: 'một tháng',
//	  MM: '%d tháng',
//	  y: 'một năm',
//	  yy: '%d năm'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}/,
//	ordinal: function (e) {
//	  return e
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('x-pseudo', {
//	months: 'J~áñúá~rý_F~ébrú~árý_~Márc~h_Áp~ríl_~Máý_~Júñé~_Júl~ý_Áú~gúst~_Sép~témb~ér_Ó~ctób~ér_Ñ~óvém~bér_~Décé~mbér'.split('_'),
//	monthsShort: 'J~áñ_~Féb_~Már_~Ápr_~Máý_~Júñ_~Júl_~Áúg_~Sép_~Óct_~Ñóv_~Déc'.split('_'),
//	monthsParseExact: !0,
//	weekdays: 'S~úñdá~ý_Mó~ñdáý~_Túé~sdáý~_Wéd~ñésd~áý_T~húrs~dáý_~Fríd~áý_S~átúr~dáý'.split('_'),
//	weekdaysShort: 'S~úñ_~Móñ_~Túé_~Wéd_~Thú_~Frí_~Sát'.split('_'),
//	weekdaysMin: 'S~ú_Mó~_Tú_~Wé_T~h_Fr~_Sá'.split('_'),
//	weekdaysParseExact: !0,
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY HH:mm',
//	  LLLL: 'dddd, D MMMM YYYY HH:mm'
//	},
//	calendar: {
//	  sameDay: '[T~ódá~ý át] LT',
//	  nextDay: '[T~ómó~rró~w át] LT',
//	  nextWeek: 'dddd [át] LT',
//	  lastDay: '[Ý~ést~érdá~ý át] LT',
//	  lastWeek: '[L~ást] dddd [át] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'í~ñ %s',
//	  past: '%s á~gó',
//	  s: 'á ~féw ~sécó~ñds',
//	  ss: '%d s~écóñ~ds',
//	  m: 'á ~míñ~úté',
//	  mm: '%d m~íñú~tés',
//	  h: 'á~ñ hó~úr',
//	  hh: '%d h~óúrs',
//	  d: 'á ~dáý',
//	  dd: '%d d~áýs',
//	  M: 'á ~móñ~th',
//	  MM: '%d m~óñt~hs',
//	  y: 'á ~ýéár',
//	  yy: '%d ý~éárs'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(th|st|nd|rd)/,
//	ordinal: function (e) {
//	  var t = e % 10;
//	  return e + (1 == ~~(e % 100 / 10) ? 'th' : 1 === t ? 'st' : 2 === t ? 'nd' : 3 === t ? 'rd' : 'th')
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('yo', {
//	months: 'Sẹ́rẹ́_Èrèlè_Ẹrẹ̀nà_Ìgbé_Èbibi_Òkùdu_Agẹmo_Ògún_Owewe_Ọ̀wàrà_Bélú_Ọ̀pẹ̀̀'.split('_'),
//	monthsShort: 'Sẹ́r_Èrl_Ẹrn_Ìgb_Èbi_Òkù_Agẹ_Ògú_Owe_Ọ̀wà_Bél_Ọ̀pẹ̀̀'.split('_'),
//	weekdays: 'Àìkú_Ajé_Ìsẹ́gun_Ọjọ́rú_Ọjọ́bọ_Ẹtì_Àbámẹ́ta'.split('_'),
//	weekdaysShort: 'Àìk_Ajé_Ìsẹ́_Ọjr_Ọjb_Ẹtì_Àbá'.split('_'),
//	weekdaysMin: 'Àì_Aj_Ìs_Ọr_Ọb_Ẹt_Àb'.split('_'),
//	longDateFormat: {
//	  LT: 'h:mm A',
//	  LTS: 'h:mm:ss A',
//	  L: 'DD/MM/YYYY',
//	  LL: 'D MMMM YYYY',
//	  LLL: 'D MMMM YYYY h:mm A',
//	  LLLL: 'dddd, D MMMM YYYY h:mm A'
//	},
//	calendar: {
//	  sameDay: '[Ònì ni] LT',
//	  nextDay: '[Ọ̀la ni] LT',
//	  nextWeek: 'dddd [Ọsẹ̀ tón\'bọ] [ni] LT',
//	  lastDay: '[Àna ni] LT',
//	  lastWeek: 'dddd [Ọsẹ̀ tólọ́] [ni] LT',
//	  sameElse: 'L'
//	},
//	relativeTime: {
//	  future: 'ní %s',
//	  past: '%s kọjá',
//	  s: 'ìsẹjú aayá die',
//	  ss: 'aayá %d',
//	  m: 'ìsẹjú kan',
//	  mm: 'ìsẹjú %d',
//	  h: 'wákati kan',
//	  hh: 'wákati %d',
//	  d: 'ọjọ́ kan',
//	  dd: 'ọjọ́ %d',
//	  M: 'osù kan',
//	  MM: 'osù %d',
//	  y: 'ọdún kan',
//	  yy: 'ọdún %d'
//	},
//	dayOfMonthOrdinalParse: /ọjọ́\s\d{1,2}/,
//	ordinal: 'ọjọ́ %d',
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//}, function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('zh-cn', {
//	months: '一月_二月_三月_四月_五月_六月_七月_八月_九月_十月_十一月_十二月'.split('_'),
//	monthsShort: '1月_2月_3月_4月_5月_6月_7月_8月_9月_10月_11月_12月'.split('_'),
//	weekdays: '星期日_星期一_星期二_星期三_星期四_星期五_星期六'.split('_'),
//	weekdaysShort: '周日_周一_周二_周三_周四_周五_周六'.split('_'),
//	weekdaysMin: '日_一_二_三_四_五_六'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'YYYY/MM/DD',
//	  LL: 'YYYY年M月D日',
//	  LLL: 'YYYY年M月D日Ah点mm分',
//	  LLLL: 'YYYY年M月D日ddddAh点mm分',
//	  l: 'YYYY/M/D',
//	  ll: 'YYYY年M月D日',
//	  lll: 'YYYY年M月D日 HH:mm',
//	  llll: 'YYYY年M月D日dddd HH:mm'
//	},
//	meridiemParse: /凌晨|早上|上午|中午|下午|晚上/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  '凌晨' === t || '早上' === t || '上午' === t ? e : '下午' === t || '晚上' === t ? e + 12 : e >= 11 ? e : e + 12
//	},
//	meridiem: function (e, t, n) {
//	  var r = 100 * e + t;
//	  return r < 600 ? '凌晨' : r < 900 ? '早上' : r < 1130 ? '上午' : r < 1230 ? '中午' : r < 1800 ? '下午' : '晚上'
//	},
//	calendar: {
//	  sameDay: '[今天]LT',
//	  nextDay: '[明天]LT',
//	  nextWeek: '[下]ddddLT',
//	  lastDay: '[昨天]LT',
//	  lastWeek: '[上]ddddLT',
//	  sameElse: 'L'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(日|月|周)/,
//	ordinal: function (e, t) {
//	  switch (t) {
//		case 'd':
//		case 'D':
//		case 'DDD':
//		  return e + '日';
//		case 'M':
//		  return e + '月';
//		case 'w':
//		case 'W':
//		  return e + '周';
//		default:
//		  return e
//	  }
//	},
//	relativeTime: {
//	  future: '%s内',
//	  past: '%s前',
//	  s: '几秒',
//	  ss: '%d 秒',
//	  m: '1 分钟',
//	  mm: '%d 分钟',
//	  h: '1 小时',
//	  hh: '%d 小时',
//	  d: '1 天',
//	  dd: '%d 天',
//	  M: '1 个月',
//	  MM: '%d 个月',
//	  y: '1 年',
//	  yy: '%d 年'
//	},
//	week: {
//	  dow: 1,
//	  doy: 4
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('zh-hk', {
//	months: '一月_二月_三月_四月_五月_六月_七月_八月_九月_十月_十一月_十二月'.split('_'),
//	monthsShort: '1月_2月_3月_4月_5月_6月_7月_8月_9月_10月_11月_12月'.split('_'),
//	weekdays: '星期日_星期一_星期二_星期三_星期四_星期五_星期六'.split('_'),
//	weekdaysShort: '週日_週一_週二_週三_週四_週五_週六'.split('_'),
//	weekdaysMin: '日_一_二_三_四_五_六'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'YYYY/MM/DD',
//	  LL: 'YYYY年M月D日',
//	  LLL: 'YYYY年M月D日 HH:mm',
//	  LLLL: 'YYYY年M月D日dddd HH:mm',
//	  l: 'YYYY/M/D',
//	  ll: 'YYYY年M月D日',
//	  lll: 'YYYY年M月D日 HH:mm',
//	  llll: 'YYYY年M月D日dddd HH:mm'
//	},
//	meridiemParse: /凌晨|早上|上午|中午|下午|晚上/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  '凌晨' === t || '早上' === t || '上午' === t ? e : '中午' === t ? e >= 11 ? e : e + 12 : '下午' === t || '晚上' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  var r = 100 * e + t;
//	  return r < 600 ? '凌晨' : r < 900 ? '早上' : r < 1130 ? '上午' : r < 1230 ? '中午' : r < 1800 ? '下午' : '晚上'
//	},
//	calendar: {
//	  sameDay: '[今天]LT',
//	  nextDay: '[明天]LT',
//	  nextWeek: '[下]ddddLT',
//	  lastDay: '[昨天]LT',
//	  lastWeek: '[上]ddddLT',
//	  sameElse: 'L'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(日|月|週)/,
//	ordinal: function (e, t) {
//	  switch (t) {
//		case 'd':
//		case 'D':
//		case 'DDD':
//		  return e + '日';
//		case 'M':
//		  return e + '月';
//		case 'w':
//		case 'W':
//		  return e + '週';
//		default:
//		  return e
//	  }
//	},
//	relativeTime: {
//	  future: '%s內',
//	  past: '%s前',
//	  s: '幾秒',
//	  ss: '%d 秒',
//	  m: '1 分鐘',
//	  mm: '%d 分鐘',
//	  h: '1 小時',
//	  hh: '%d 小時',
//	  d: '1 天',
//	  dd: '%d 天',
//	  M: '1 個月',
//	  MM: '%d 個月',
//	  y: '1 年',
//	  yy: '%d 年'
//	}
//  })
//})
//},
//function (e, t, n) {
//!function (e, t) {
//  t(n(3))
//}(0, function (e) {
//  'use strict';
//  return e.defineLocale('zh-tw', {
//	months: '一月_二月_三月_四月_五月_六月_七月_八月_九月_十月_十一月_十二月'.split('_'),
//	monthsShort: '1月_2月_3月_4月_5月_6月_7月_8月_9月_10月_11月_12月'.split('_'),
//	weekdays: '星期日_星期一_星期二_星期三_星期四_星期五_星期六'.split('_'),
//	weekdaysShort: '週日_週一_週二_週三_週四_週五_週六'.split('_'),
//	weekdaysMin: '日_一_二_三_四_五_六'.split('_'),
//	longDateFormat: {
//	  LT: 'HH:mm',
//	  LTS: 'HH:mm:ss',
//	  L: 'YYYY/MM/DD',
//	  LL: 'YYYY年M月D日',
//	  LLL: 'YYYY年M月D日 HH:mm',
//	  LLLL: 'YYYY年M月D日dddd HH:mm',
//	  l: 'YYYY/M/D',
//	  ll: 'YYYY年M月D日',
//	  lll: 'YYYY年M月D日 HH:mm',
//	  llll: 'YYYY年M月D日dddd HH:mm'
//	},
//	meridiemParse: /凌晨|早上|上午|中午|下午|晚上/,
//	meridiemHour: function (e, t) {
//	  return 12 === e && (e = 0),
//	  '凌晨' === t || '早上' === t || '上午' === t ? e : '中午' === t ? e >= 11 ? e : e + 12 : '下午' === t || '晚上' === t ? e + 12 : void 0
//	},
//	meridiem: function (e, t, n) {
//	  var r = 100 * e + t;
//	  return r < 600 ? '凌晨' : r < 900 ? '早上' : r < 1130 ? '上午' : r < 1230 ? '中午' : r < 1800 ? '下午' : '晚上'
//	},
//	calendar: {
//	  sameDay: '[今天]LT',
//	  nextDay: '[明天]LT',
//	  nextWeek: '[下]ddddLT',
//	  lastDay: '[昨天]LT',
//	  lastWeek: '[上]ddddLT',
//	  sameElse: 'L'
//	},
//	dayOfMonthOrdinalParse: /\d{1,2}(日|月|週)/,
//	ordinal: function (e, t) {
//	  switch (t) {
//		case 'd':
//		case 'D':
//		case 'DDD':
//		  return e + '日';
//		case 'M':
//		  return e + '月';
//		case 'w':
//		case 'W':
//		  return e + '週';
//		default:
//		  return e
//	  }
//	},
//	relativeTime: {
//	  future: '%s內',
//	  past: '%s前',
//	  s: '幾秒',
//	  ss: '%d 秒',
//	  m: '1 分鐘',
//	  mm: '%d 分鐘',
//	  h: '1 小時',
//	  hh: '%d 小時',
//	  d: '1 天',
//	  dd: '%d 天',
//	  M: '1 個月',
//	  MM: '%d 個月',
//	  y: '1 年',
//	  yy: '%d 年'
//	}
//  })
//})
//},
		}
	}
}
