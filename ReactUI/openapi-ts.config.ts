import { defineConfig } from '@hey-api/openapi-ts';

export default defineConfig({
  input: 'http://localhost:8080/swagger/v1/swagger.json', 
  output: 'src/api',
  plugins: [
    {
        name: '@hey-api/client-next',
        baseUrl: false,
    },
  ],
});