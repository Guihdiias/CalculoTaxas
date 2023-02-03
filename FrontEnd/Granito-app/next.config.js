/** @type {import('next').NextConfig} */
/** @type {require('dotenv').config()} */

const nextConfig = {
    reactStrictMode: true,
    compiler: {
        styledComponents: true,
    },
    env: {
        TAXA_URL: process.env.TAXA_URL,
        CALCULO_URL: process.env.CALCULO_URL,
    },
};

module.exports = nextConfig;