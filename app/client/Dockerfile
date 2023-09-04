# Use an official NGINX runtime as the base image
FROM nginx:latest

# Copy your HTML and CSS files to the NGINX web server directory
COPY . /usr/share/nginx/html

# Expose port 80 for HTTP traffic (the default NGINX port)
EXPOSE 80

# Start the NGINX web server when the container runs
CMD ["nginx", "-g", "daemon off;"]