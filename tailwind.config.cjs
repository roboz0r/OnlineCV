/** @type {import('tailwindcss').Config} */

const defaultTheme = require("tailwindcss/defaultTheme");

module.exports = {
  // https://tailwindcss.com/docs/configuration
  // tailwind scans these files for classes
  content: ["./src/**/*.{html,js,fs}", "./index.html"],
  theme: {
    extend: {
      fontFamily: {
        'mono': ['"Fira Code"', ...defaultTheme.fontFamily.mono],
        'sans': ['"Fira Sans"', ...defaultTheme.fontFamily.sans],
      },
    },
  },
  plugins: [
    require("@tailwindcss/typography"),
    require("@tailwindcss/forms"),
    require("daisyui"),
  ],
  // https://daisyui.com/docs/config/
  daisyui: {
    themes: false,
    darkTheme: "dark",
    base: true,
    styled: false,
    utils: true,
    prefix: "",
    logs: true,
    themeRoot: ":root",
  },
};
