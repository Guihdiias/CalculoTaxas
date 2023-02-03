import {ThemeProvider } from 'styled-components'
import { AppProps } from 'next/dist/shared/lib/router/router';
import React from 'react';
import Layout from '../src/components/Layout'
import '../src/global.css';
import { createGlobalStyle } from 'styled-components';

const GlobalStyle = createGlobalStyle`
  html,
  body {    
    overflow: hidden ;
  }
  `;



export default function App({ Component, pageProps } : AppProps) {
  return (
        <>
          <GlobalStyle />
          <Layout>
            <Component {...pageProps} />
          </Layout>
        </>
  )
}
