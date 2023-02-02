import { createGlobalStyle, ThemeProvider } from 'styled-components'
import store from '../src/store'
import { Provider } from 'react-redux';
import { AppProps } from 'next/dist/shared/lib/router/router';
import React from 'react';
import Layout from '../src/components/Layout';
import '../src/global.css';

const GlobalStyle = createGlobalStyle`
  body {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    overflow-x: hidden;
  }
`

const theme = {
  colors: {
    primary: '#0070f3',
  },
}

export default function App({ Component, pageProps } : AppProps) {
  return (
    <Provider store={store}>
        <GlobalStyle />
        <ThemeProvider theme={theme}>
          <Layout>
            <Component {...pageProps} />
          </Layout>
        </ThemeProvider>
    </Provider>
  )
}
