/* eslint-disable no-undef */
/** @type {import('next').NextConfig} */
/** @type {require('dotenv').config()} */

const nextConfig = {
    reactStrictMode: true,
    compiler: {
        styledComponents: true,
    },
    env: {
        BASE_URL: process.env.BASE_URL,
    },
};

module.exports = nextConfig;
