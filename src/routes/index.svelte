<script>
    import {browser} from '$app/env'
</script>
<h1>Welcome to SvelteKit</h1>
<p>Visit <a href="https://kit.svelte.dev">kit.svelte.dev</a> to read the documentation</p>

{#if browser}
<p1> {browser}</p1>
{:else}
<script>
    let veo =""
</script>
{/if}
<p1> ? </p1>


