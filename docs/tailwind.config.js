/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./*.{html,js}"],
  theme: {
    fontFamily: {
        'retro': ['DotGothic16'],
    },
    extend: {
      height: {
        'screen': [
          '100vh','100dvh'
        ]
      },
      minHeight: {
        'screen': [
          '100vh','100dvh'
        ]
      },
      maxHeight: {
        'screen': [
          '100vh','100dvh'
        ]
      }
    },
  },
  plugins: [],
}

