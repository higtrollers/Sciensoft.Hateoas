﻿using Sciensoft.Hateoas.WebSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sciensoft.Hateoas.WebSample.Repositories
{
	internal static class InMemoryArticleCollection
	{
		public static readonly IDictionary<Guid, ArticleViewModel> Articles = (new List<ArticleViewModel> {
			new ArticleViewModel {
				Id = Guid.Parse("{83389205-B1C9-4523-A3BB-85D7255546F9}"),
				Title = "The Girl Beneath the Sea (Underwater Investigation Unit Book 1)"
			},
			new ArticleViewModel {
				Id = Guid.Parse("{8F46D29E-6C0D-4511-85E7-B1D7AE42934A}"),
				Title = "The Girl Who Lived: A Thrilling Suspense Novel"
			},
			new ArticleViewModel {
				Id = Guid.Parse("{ED3A8B20-C914-4471-9ED3-B06AF5A2B976}"),
				Title = "What We Forgot to Bury"
			},
			new ArticleViewModel {
				Id = Guid.Parse("{52C10C98-5A0F-405F-A7BA-BF225A779961}"),
				Title = "Stories We Never Told"
			},
			new ArticleViewModel {
				Id = Guid.Parse("{9DE3C4EB-35F5-4E91-8D7A-AF25582FD596}"),
				Title = "Where the Crawdads Sing"
			},
			new ArticleViewModel {
				Id = Guid.Parse("{B6D3E7D5-26FD-4C33-B036-0EF18D79BC94}"),
				Title = "A Girl From Nowhere (The Firewall Trilogy Book 1)"
			}
		}).ToDictionary(k => k.Id);
	}
}
