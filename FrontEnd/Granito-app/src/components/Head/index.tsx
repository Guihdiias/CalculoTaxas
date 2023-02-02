import Head from 'next/head';

export default function HeadBase() {
    return (
        <Head>
            <title>Base App</title>
            <meta name="description" content="Base next app" />
            <link rel="icon" href="/favicon.ico" />
        </Head>
    );
}
