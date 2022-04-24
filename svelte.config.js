import adapter from '@sveltejs/adapter-auto';

/** @type {import('@sveltejs/kit').Config} */
const config = {
	kit: {
		adapter: adapter()
	},
	"navigationFallback": {
		"rewrite": "app.html",
		"exclude": ["/images/*.{png,jpg,gif,ico}", "/*.{css,scss,js}"]
	  }
	
};

export default config;
